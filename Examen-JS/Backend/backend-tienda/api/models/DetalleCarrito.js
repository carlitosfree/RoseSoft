/**
 * DetalleCarrito.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    cantidad: {
      type: 'number'
    },
    precio:{
      type: 'number'
    },
    subtotal: {
      type: 'number'
    },
    idProstituta: {
      model: 'prostituta',
      required:true
    },
    idCabecera: {
      model: 'cabeceraCarrito',
      required: true
    }
  },

};

