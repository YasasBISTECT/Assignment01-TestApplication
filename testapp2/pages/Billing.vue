<template>
 <b-container fluid>
    <Logo />
    <h1 class="title">testapplication - E_COM</h1>
    <div class="mt-3">
      <b-button-group>
        <b-button-toolbar key-nav aria-label="Toolbar with button groups">
          <b-button-group class="mx-1">
            <b-button>&lsaquo;</b-button>
          </b-button-group>
          <b-button-group class="mx-1">
            <b-button>&rsaquo;</b-button>
          </b-button-group>
        </b-button-toolbar>
        <b-button variant="info">Account Details</b-button>
        <b-button variant="success">Billing Details</b-button>
        <b-button variant="info">Shipping Details</b-button>
      </b-button-group>
    </div>
    <div></div>
    <b-row v-for="type in types" :key="type" class="my-3">
      <b-col sm="3">
        <label :for="`type-${type}`">
          <code>{{ type }}</code> :</label
        >
      </b-col>
      <b-col sm="5">
        <b-form-input :id="`type-${type}`" :type="type"></b-form-input>
      </b-col>
    </b-row>
    <div></div>
    <div>
      <b-button href="index.vue" variant="outline-primary">Back</b-button>
      <b-button href="Shipping" variant="outline-primary">Next</b-button>
    </div>
  </b-container>
  <!-- </div> -->
</template>
<script>
export default {
  data() {
    return {
      types: [
         'Street Address 1',
        'Street Address2',
        'City',
        'District',
      ],
    }
  },
}
</script>
