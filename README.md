# Node Ekleme

Bu C# sınıfı, ağaç veri yapısını oluşturmak için kullanılır. `tree` adlı bir sınıf içerir ve `nodeEkle` metodunu kullanarak ağaca düğüm eklemeyi sağlar.

## `tree` Sınıfı

```csharp
class tree
{
    public int value;
    public tree right;
    public tree left;
}
```

### Özellikler

- `value`: Düğümün değerini temsil eder.
- `right`: Düğüme bağlı olan sağ alt düğümü belirtir.
- `left`: Düğüme bağlı olan sol alt düğümü belirtir.

<style>
    .arrow-1 {
  width:100px;
  height:30px;
  display: flex;
}
.arrow-1:before {
  content: "";
  background: currentColor;
  width:15px;
  clip-path: polygon(0 10px,calc(100% - 15px) 10px,calc(100% - 15px) 0,100% 50%,calc(100% - 15px) 100%,calc(100% - 15px) calc(100% - 10px),0 calc(100% - 10px));
  animation: a1 1.5s infinite linear;
}
@keyframes a1 {
  90%,100%{flex-grow: 1}
}
</style>

<div>
    <img scr="https://github.com/yasir723/node-ekle/assets/111686779/2da03747-b1ff-458d-9833-40b0b0fec822" >
    <div class="arrow-1"></div>
    <img scr="https://github.com/yasir723/node-ekle/assets/111686779/ccf5e610-addc-480d-9481-ab29be2bb111" >
</div>

```csharp
static tree nodeEkle(tree node, int value)
{
    tree tmp = new tree();
    tmp.value = value;

    if (node == null)
    {
        node = tmp;
        return node;
    }

    if (node.value < value)
    {
        if (node.right == null)
            node.right = tmp;
        else
            nodeEkle(node.right, value);
    }

    if (node.value > value)
    {
        if (node.left == null)
            node.left = tmp;
        else
            nodeEkle(node.left, value);
    }

    return node;
}
```

## Parametreler

- `node`: Ağaçtaki mevcut düğüm.
- `value`: Eklenecek düğümün değeri.

## Dönüş Değeri

Metot, güncellenmiş ağaç yapısını temsil eden kök düğümü döndürür.

## İşleyiş

1. Eğer mevcut düğüm null ise, yeni düğüm oluşturulur ve ağacın kökü olarak atanır.
2. Eğer mevcut düğüm null değilse, eklenen değere göre ağaç içerisinde uygun konuma gidilir.
3. Eğer eklenen değer mevcut düğümün değerinden büyükse, sağ alt ağaca git ve eğer sağ alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sağ alt ağacın altında işlem tekrarlanır.
4. Eğer eklenen değer mevcut düğümün değerinden küçükse, sol alt ağaca git ve eğer sol alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sol alt ağacın altında işlem tekrarlanır.
5. İşlem tamamlandığında güncellenmiş ağaç yapısını temsil eden kök düğüm döndürülür.
