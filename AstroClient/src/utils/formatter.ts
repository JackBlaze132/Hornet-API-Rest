import { h1 } from "framer-motion/client";

class Formatter {
    private static instance: Formatter;
  
    private constructor() {}
  
    public static getInstance(): Formatter {
      if (!Formatter.instance) {
        Formatter.instance = new Formatter();
      }
      return Formatter.instance;
    }
  
    public booleanToString(value: boolean): string {
      return value ? 'Yes' : 'No';
    }
    public formatDate(dateString: string): string {
        const date = new Date(dateString);
        const day = String(date.getDate()).padStart(2, '0');
        const month = String(date.getMonth() + 1).padStart(2, '0'); // Los meses en JavaScript son 0-indexados
        const year = date.getFullYear();
        const hours = String(date.getHours()).padStart(2, '0');
        const minutes = String(date.getMinutes()).padStart(2, '0');
        return `${day}/${month}/${year} - ${hours}:${minutes}`;
      }
    
  }
  
  export default Formatter;