
class API{
  private readonly API_BASE_URL: string = 'http://localhost:8090/';
  // ya se encuentra registrada en el archivo vite.config.mts
  //----[ENDPOINTS]----

  public readonly MOTORCYCLES:string="motorcycles"
  //----[GET]----
  public readonly GET_BODYWORKS:string='bodyworks/get';
  public readonly GET_AUTOMOBILES:string='automobiles/get';
  public readonly GET_MOTORCYCLES:string='motorcycles/get';
  public readonly SEARCH_BODYWORKS:string='bodyworks/search';
  public readonly SEARCH_AUTOMOBILE:string='automobiles/search';
  public readonly SEARCH_MOTORCYCLES:string='motorcycles/search';


  //----[POST]----
  public readonly POST_BODYWORKS:string='bodyworks/add';
  public readonly POST_AUTOMOBILES:string='automobiles/add';
  public readonly POST_MOTORCYCLES:string='motorcycles/add';

  //----[PUT]----
  public readonly PUT_BODYWORKS:string='bodyworks/update';
  public readonly PUT_AUTOMOBILES:string='automobiles/update';
  public readonly PUT_MOTORCYCLES:string='motorcycles/update';


  //----[DELETE]----
  public readonly DELETE_BODYWORKS:string='bodyworks/delete';
  public readonly DELETE_AUTOMOBILES:string='automobiles/delete';
  public readonly DELETE_MOTORCYCLES:string='motorcycles/delete';



  private static instance: API;

  private constructor() {}

  

  public static getInstance(): API {
    if (!API.instance) {
      API.instance = new API();
    }
    return API.instance;
  }

   /**public async get(endpoint: string, headers: Record<string, string> = {}): Promise<any> {
    try {
      const response = await fetch(this.API_BASE_URL + `${endpoint}`, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
          ...headers, // Agregar headers personalizados si existen
        },
      });
      const data = await response.json();
      return Array.isArray(data) ? data : [data];
    } catch (error) {
      console.error(`Error fetching ${endpoint}:`, error);
      throw error;
    }
  }**/

    public getFullUrl(endpoint: string): string {
      return this.API_BASE_URL + endpoint;
    }


    public async get(endpoint: string, params?: { [key: string]: any }) {
      try {
        const url = new URL(this.getFullUrl(endpoint));
        if (params) {
          Object.keys(params).forEach(key => {
            if (params[key] !== null) {
              url.searchParams.append(key, params[key]);
            }
          });
        }
        const response = await fetch(url.toString(), {
          method: 'GET',
          headers: {
            'Content-Type': 'application/json'
          }
        });
        const data = await response.json();
        return Array.isArray(data) ? data : [data];
      } catch (error) {
        console.error(`Error fetching ${endpoint}:`, error);
        throw error;
      }
    }

  public async post(endpoint: string, data: any) {
    try {
      const response = await fetch(this.API_BASE_URL + `${endpoint}`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      });
      return response.json();
    } catch (error) {
      console.error(`Error posting to ${endpoint}:`, error);
      throw error;
    }
  }

  public async put(endpoint: string, data: any) {
    try {
      const response = await fetch(this.API_BASE_URL + `${endpoint}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      });
      return response.json();
    } catch (error) {
      console.error(`Error patching to ${endpoint}:`, error);
      throw error;
    }
  }

  public async delete(endpoint: string, id: string) {
    try{
    const response = await fetch(this.API_BASE_URL + `${endpoint}/${id}`, {
      method: 'DELETE',
    });
    return response;
  } catch (error) {
    console.error(`Error deleting from ${endpoint}:`, error);
    throw error;
  }
}

}

export default API.getInstance()



