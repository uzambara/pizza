export class LocalStorageService {
    public static getItem<T extends object>(key: string): T {
        const data = localStorage.getItem(key);

        if(data != null) {
            return JSON.parse(data);
        }
    }

    public static setItem<T extends object>(key: string, object: T): void {
        localStorage.setItem(key, JSON.stringify(object));
    }

    public static remove(key: string): void {
        localStorage.removeItem(key);
    }
}