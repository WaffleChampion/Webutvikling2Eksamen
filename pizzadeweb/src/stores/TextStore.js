const TextStore = {
//store som inneholder text
    state: {
        texts: [
            {id: 100, info: "imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum"},
            {id: 101, info: "semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante,"},
            {id: 102, info: "dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam"},
            {id: 103, info: "ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum"},
            {id: 104, info: "rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id,"},
            {id: 105, info: "lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet"},
            {id: 106, info: "orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, "},
            {id: 111, info: "semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante,"},
            {id: 118, info: "Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim"},
            {id: 119, info: "aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, "},
            {id: 120, info: "Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut,"},
            {id: 126, info: "sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis le"},
            {id: 127, info: "amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue "},
            {id: 128, info: "mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula,"},
            {id: 129, info: "Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem"},
            {id: 130, info: "penatibus et magnis dis parturien"}
        ]
    },

    setTexts(){
        //axios kall for å sette this.state.texts = result.data
    },

    getTexts(){
        return this.state.texts.map( text => text);
    }

}

export default TextStore