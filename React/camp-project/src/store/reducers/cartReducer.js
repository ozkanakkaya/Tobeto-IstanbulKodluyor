import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

const initialState = {
  cartItems: cartItems,
};

export default function cartReducer(state = initialState, { type, payload }) {
  switch (type) {
    case ADD_TO_CART:
      let product = state.cartItems.find((c) => c.product.id === payload.id); //Sepetteki ürünler arasında eklenmek istenen ürünü bulmaya çalışıyoruz.
      if (product) {
        product.quantity++; // Eğer ürün sepette zaten varsa, stoğunu artır
        return {
          ...state, //Durumu değiştirmedik, sadece güncellenmiş ürünü içeren yeni bir nesne döndürdük.
        };
      } else {
        return {
          //Eğer ürün sepette yoksa, yeni bir öğe olarak ekleyerek sepeti güncelle.
          ...state,
          cartItems: [...state.cartItems, { quantity: 1, product: payload }],
        };
      }
      
    case REMOVE_FROM_CART:
      return {
        ...state,
        cartItems: state.cartItems.filter((c) => c.product.id !== payload.id), //Belirtilen ürünü sepetten filtreleyerek çıkart.
      };
    default:
      return state;
  }
}
