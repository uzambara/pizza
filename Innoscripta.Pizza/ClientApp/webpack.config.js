var path = require("path");
const HTMLWebpackPlugin = require('html-webpack-plugin');
const {CleanWebpackPlugin} = require('clean-webpack-plugin');
const CopyWebpackPlugin = require('copy-webpack-plugin');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const OptimizeCssAssetWebpackPlugin = require('optimize-css-assets-webpack-plugin');
const TerserWebpackPlugin = require('terser-webpack-plugin');
const {BundleAnalyzerPlugin} = require('webpack-bundle-analyzer');
const autoprefixer = require('autoprefixer');

let isDev = true;
let isProd = !isDev;
const publicPath = isDev ? "" : "/";

const optimization = () => {
    const config = {
        splitChunks: {
            chunks: 'all'
        }
    };

    if (isProd) {
        config.minimizer = [
            new OptimizeCssAssetWebpackPlugin(),
            //new TerserWebpackPlugin()
        ]
    }

    return config
};

const filename = ext => isDev ? `[name].${ext}` : `[name].[hash].${ext}`;

const cssLoaders = (...extra) => {
    const loaders = [
        { loader: "style-loader" },
        {
            loader: "css-loader",
            options: {
                localsConvention: 'camelCase',
                modules: {
                    mode: "local",
                    localIdentName: "[local]--[hash:base64:5]"
                }
            }
        }
    ];

    if (extra) {
        loaders.push(...extra)
    }

    return loaders
};

const localNameCssLoaders = (...extra) => {
    const loaders = [
        { loader: "style-loader" },
        {
            loader: "css-loader",
            options: {
                modules: {
                    mode: "local",
                    localIdentName: "[local]"
                }
            }
        }
    ];

    if (extra) {
        loaders.push(...extra)
    }

    return loaders
};

const sassLoaders = () => {
    var extra = [];

    extra.push({
        loader: 'postcss-loader',
        options: {
            plugins: [autoprefixer]
        }
    });

    extra.push({
        loader: 'sass-loader',
        options: {
            data: '@import "./src/constants.scss";',
            includePaths:[__dirname, 'src']
        }
    });
    const loaders = cssLoaders(...extra);

    return loaders;
};

const localNameSassLoaders = () => {
    var extra = [];

    extra.push({
        loader: 'postcss-loader',
        options: {
            plugins: [autoprefixer]
        }
    });

    extra.push({
        loader: 'sass-loader',
        options: {
            data: '@import "./src/constants.scss";',
            includePaths:[__dirname, 'src']
        }
    });
    const loaders = localNameCssLoaders(...extra);

    return loaders;
};


const imagesLoaders = () => {
    const loaders = [
        {
            loader: "file-loader",
            options: {
                outputPath: "images"
            }
        }
    ];

    return loaders;
};

const fontsLoaders = () => {
    const loaders = [
        {
            loader: 'file-loader',
            options: {
                name: '[name].[ext]',
                outputPath: './fonts/'
            }
        }
    ];

    return loaders;
};

const plugins = () => {
    const base = [];

    base.push(new CopyWebpackPlugin([
        {
            from: path.resolve(__dirname, 'images'),
            to: path.resolve(__dirname, 'build/images')
        }
    ]));

    base.push(
        new HTMLWebpackPlugin({
            template: './index.html',
            minify: {
                collapseWhitespace: isProd
            }
        }),

        new MiniCssExtractPlugin({
            filename: filename('css')
        })
    );

    if (isProd) {
        base.push(new CleanWebpackPlugin());
        //base.push(new BundleAnalyzerPlugin())
    }

    return base
};


module.exports = function(env, args) {
    isDev = args.mode === "development";
    isProd = !isDev;

    var res = {
        context: path.resolve(__dirname, 'src'),
        entry: ["@babel/polyfill", "./index.tsx"],
        output: {
            path: path.resolve(__dirname, "build"),
            filename: "bundle.js",
            publicPath: publicPath
        },
        plugins: plugins(),
        module: {
            rules: [
                {
                    test: /\.ts(x?)$/,
                    exclude: "/node_modules/",
                    use: "ts-loader"
                },
                {
                    test: /\.js(x?)$/,
                    exclude: "/node_modules/",
                    use: "babel-loader"
                },
                {
                    test: /\.css$/,
                    exclude: /node_modules/,
                    use: cssLoaders()
                },
                {
                    test: /\.css$/,
                    include: /node_modules/,
                    use: localNameCssLoaders()
                },
                {
                    test: /\.scss$/,
                    exclude: [/pizza-toast/],
                    use: sassLoaders()
                },
                {
                    test: /\.scss$/,
                    include: [/pizza-toast/],
                    use: localNameSassLoaders()
                },
                {
                    test: /\.(png|jpg|gif|svg|webp)$/i,
                    use: imagesLoaders()
                },
                {
                    test: /\.(woff(2)?|ttf|eot)(\?v=\d+\.\d+\.\d+)?$/,
                    use: fontsLoaders()
                }
            ]
        },
        resolve: {
            extensions: [".ts", ".tsx", ".js", ".jsx"]
        },
        optimization: optimization(),
        devtool: isDev ? 'source-map' : '',
        devServer: {
            compress: true,
            contentBase: path.resolve(__dirname, "build"),
            historyApiFallback: true
        }
    };
    return res;
};