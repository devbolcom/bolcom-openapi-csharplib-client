using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;


public partial class Login
{

    private string sessionIdField;

    private string nameField;

    private bool mergedBasketField;

    public string SessionId
    {
        get
        {
            return sessionIdField;
        }
        set
        {
            sessionIdField = value;
        }
    }

    public string Name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    public bool MergedBasket
    {
        get
        {
            return mergedBasketField;
        }
        set
        {
            mergedBasketField = value;
        }
    }
}

public partial class RequestAuthToken
{

    private string privateTokenField;

    private string codeField;

    private string urlField;

    public string PrivateToken
    {
        get
        {
            return privateTokenField;
        }
        set
        {
            privateTokenField = value;
        }
    }

    public string Code
    {
        get
        {
            return codeField;
        }
        set
        {
            codeField = value;
        }
    }

    public string Url
    {
        get
        {
            return urlField;
        }
        set
        {
            urlField = value;
        }
    }
}

public partial class Session
{

    private string sessionIdField;

    public string SessionId
    {
        get
        {
            return sessionIdField;
        }
        set
        {
            sessionIdField = value;
        }
    }
}

public partial class ProductList
{

    private List<Product> productsField;

    public ProductList()
    {
        productsField = new List<Product>();
    }

    public List<Product> Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }
}

public partial class Product
{

    private string idField;

    private string eANField;

    private string gPCField;

    private string titleField;

    private string subtitleField;

    private string summaryField;

    private int ratingField;

    private bool ratingFieldSpecified;

    private string shortDescriptionField;

    private string longDescriptionField;

    private List<TrackList> trackListsField;

    private List<AttributeGroup> attributeGroupsField;

    private List<EntityGroup> entityGroupsField;

    private List<Entry> urlsField;

    private List<MediaEntry> imagesField;

    private List<MediaEntry> mediaField;

    private OfferData offerDataField;

    private List<Promotion> promotionsField;

    private List<ParentCategory> parentCategoryPathsField;

    public Product()
    {
        parentCategoryPathsField = new List<ParentCategory>();
        promotionsField = new List<Promotion>();
        offerDataField = new OfferData();
        mediaField = new List<MediaEntry>();
        imagesField = new List<MediaEntry>();
        urlsField = new List<Entry>();
        entityGroupsField = new List<EntityGroup>();
        attributeGroupsField = new List<AttributeGroup>();
        trackListsField = new List<TrackList>();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string EAN
    {
        get
        {
            return eANField;
        }
        set
        {
            eANField = value;
        }
    }

    public string GPC
    {
        get
        {
            return gPCField;
        }
        set
        {
            gPCField = value;
        }
    }

    public string Title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }

    public string Subtitle
    {
        get
        {
            return subtitleField;
        }
        set
        {
            subtitleField = value;
        }
    }

    public string Summary
    {
        get
        {
            return summaryField;
        }
        set
        {
            summaryField = value;
        }
    }

    public int Rating
    {
        get
        {
            return ratingField;
        }
        set
        {
            ratingField = value;
        }
    }

    [XmlIgnore()]
    public bool RatingSpecified
    {
        get
        {
            return ratingFieldSpecified;
        }
        set
        {
            ratingFieldSpecified = value;
        }
    }

    public string ShortDescription
    {
        get
        {
            return shortDescriptionField;
        }
        set
        {
            shortDescriptionField = value;
        }
    }

    public string LongDescription
    {
        get
        {
            return longDescriptionField;
        }
        set
        {
            longDescriptionField = value;
        }
    }

    public List<TrackList> TrackLists
    {
        get
        {
            return trackListsField;
        }
        set
        {
            trackListsField = value;
        }
    }

    public List<AttributeGroup> AttributeGroups
    {
        get
        {
            return attributeGroupsField;
        }
        set
        {
            attributeGroupsField = value;
        }
    }

    public List<EntityGroup> EntityGroups
    {
        get
        {
            return entityGroupsField;
        }
        set
        {
            entityGroupsField = value;
        }
    }

    public List<Entry> Urls
    {
        get
        {
            return urlsField;
        }
        set
        {
            urlsField = value;
        }
    }

    public List<MediaEntry> Images
    {
        get
        {
            return imagesField;
        }
        set
        {
            imagesField = value;
        }
    }

    public List<MediaEntry> Media
    {
        get
        {
            return mediaField;
        }
        set
        {
            mediaField = value;
        }
    }

    public OfferData OfferData
    {
        get
        {
            return offerDataField;
        }
        set
        {
            offerDataField = value;
        }
    }

    public List<Promotion> Promotions
    {
        get
        {
            return promotionsField;
        }
        set
        {
            promotionsField = value;
        }
    }

    [XmlArray(Order = 17)]
    [XmlArrayItem("ParentCategories", typeof(ParentCategory), IsNullable = false)]
    public List<ParentCategory> ParentCategoryPaths
    {
        get
        {
            return parentCategoryPathsField;
        }
        set
        {
            parentCategoryPathsField = value;
        }
    }
}

public partial class TrackList
{

    private int discNumberField;

    private List<Track> trackField;

    public TrackList()
    {
        trackField = new List<Track>();
    }

    public int DiscNumber
    {
        get
        {
            return discNumberField;
        }
        set
        {
            discNumberField = value;
        }
    }

    public List<Track> Track
    {
        get
        {
            return trackField;
        }
        set
        {
            trackField = value;
        }
    }
}

public partial class Track
{

    private string titleField;

    private int trackNumberField;

    public string Title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }

    public int TrackNumber
    {
        get
        {
            return trackNumberField;
        }
        set
        {
            trackNumberField = value;
        }
    }
}

public partial class AttributeGroup
{

    private string titleField;

    private List<Entry> attributesField;

    public AttributeGroup()
    {
        attributesField = new List<Entry>();
    }

    public string Title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }

    public List<Entry> Attributes
    {
        get
        {
            return attributesField;
        }
        set
        {
            attributesField = value;
        }
    }
}

public partial class Entry
{

    private string keyField;

    private string labelField;

    private string valueField;

    public string Key
    {
        get
        {
            return keyField;
        }
        set
        {
            keyField = value;
        }
    }

    public string Label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }

    public string Value
    {
        get
        {
            return valueField;
        }
        set
        {
            valueField = value;
        }
    }
}

public partial class EntityGroup
{

    private string titleField;

    private List<Entity> entitiesField;

    public EntityGroup()
    {
        entitiesField = new List<Entity>();
    }

    public string Title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }

    public List<Entity> Entities
    {
        get
        {
            return entitiesField;
        }
        set
        {
            entitiesField = value;
        }
    }
}

public partial class Entity
{

    private string idField;

    private string labelField;

    private string valueField;

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }

    public string Value
    {
        get
        {
            return valueField;
        }
        set
        {
            valueField = value;
        }
    }
}

public partial class MediaEntry
{

    private string typeField;

    private string keyField;

    private string urlField;

    public string Type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }

    public string Key
    {
        get
        {
            return keyField;
        }
        set
        {
            keyField = value;
        }
    }

    public string Url
    {
        get
        {
            return urlField;
        }
        set
        {
            urlField = value;
        }
    }
}

public partial class OfferData
{

    private int bolcomField;

    private bool bolcomFieldSpecified;

    private int nonProfessionalSellersField;

    private bool nonProfessionalSellersFieldSpecified;

    private int professionalSellersField;

    private bool professionalSellersFieldSpecified;

    private List<Offer> offersField;

    public OfferData()
    {
        offersField = new List<Offer>();
    }

    public int Bolcom
    {
        get
        {
            return bolcomField;
        }
        set
        {
            bolcomField = value;
        }
    }

    [XmlIgnore()]
    public bool BolcomSpecified
    {
        get
        {
            return bolcomFieldSpecified;
        }
        set
        {
            bolcomFieldSpecified = value;
        }
    }

    public int NonProfessionalSellers
    {
        get
        {
            return nonProfessionalSellersField;
        }
        set
        {
            nonProfessionalSellersField = value;
        }
    }

    [XmlIgnore()]
    public bool NonProfessionalSellersSpecified
    {
        get
        {
            return nonProfessionalSellersFieldSpecified;
        }
        set
        {
            nonProfessionalSellersFieldSpecified = value;
        }
    }

    public int ProfessionalSellers
    {
        get
        {
            return professionalSellersField;
        }
        set
        {
            professionalSellersField = value;
        }
    }

    [XmlIgnore()]
    public bool ProfessionalSellersSpecified
    {
        get
        {
            return professionalSellersFieldSpecified;
        }
        set
        {
            professionalSellersFieldSpecified = value;
        }
    }

    public List<Offer> Offers
    {
        get
        {
            return offersField;
        }
        set
        {
            offersField = value;
        }
    }
}

public partial class Offer
{

    private string idField;

    private string conditionField;

    private double priceField;

    private bool priceFieldSpecified;

    private double listPriceField;

    private bool listPriceFieldSpecified;

    private string availabilityCodeField;

    private string availabilityDescriptionField;

    private string commentField;

    private Seller sellerField;

    public Offer()
    {
        sellerField = new Seller();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Condition
    {
        get
        {
            return conditionField;
        }
        set
        {
            conditionField = value;
        }
    }

    public double Price
    {
        get
        {
            return priceField;
        }
        set
        {
            priceField = value;
        }
    }

    [XmlIgnore()]
    public bool PriceSpecified
    {
        get
        {
            return priceFieldSpecified;
        }
        set
        {
            priceFieldSpecified = value;
        }
    }

    public double ListPrice
    {
        get
        {
            return listPriceField;
        }
        set
        {
            listPriceField = value;
        }
    }

    [XmlIgnore()]
    public bool ListPriceSpecified
    {
        get
        {
            return listPriceFieldSpecified;
        }
        set
        {
            listPriceFieldSpecified = value;
        }
    }

    public string AvailabilityCode
    {
        get
        {
            return availabilityCodeField;
        }
        set
        {
            availabilityCodeField = value;
        }
    }

    public string AvailabilityDescription
    {
        get
        {
            return availabilityDescriptionField;
        }
        set
        {
            availabilityDescriptionField = value;
        }
    }

    public string Comment
    {
        get
        {
            return commentField;
        }
        set
        {
            commentField = value;
        }
    }

    public Seller Seller
    {
        get
        {
            return sellerField;
        }
        set
        {
            sellerField = value;
        }
    }
}

public partial class Seller
{

    private string idField;

    private string sellerTypeField;

    private string displayNameField;

    private int numberOfReviewsField;

    private bool numberOfReviewsFieldSpecified;

    private int overallRatingField;

    private bool overallRatingFieldSpecified;

    private string urlField;

    private string logoField;

    private string emailAddressField;

    private string phoneNumberField;

    private string addressLine1Field;

    private string addressLine2Field;

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string SellerType
    {
        get
        {
            return sellerTypeField;
        }
        set
        {
            sellerTypeField = value;
        }
    }

    public string DisplayName
    {
        get
        {
            return displayNameField;
        }
        set
        {
            displayNameField = value;
        }
    }

    public int NumberOfReviews
    {
        get
        {
            return numberOfReviewsField;
        }
        set
        {
            numberOfReviewsField = value;
        }
    }

    [XmlIgnore()]
    public bool NumberOfReviewsSpecified
    {
        get
        {
            return numberOfReviewsFieldSpecified;
        }
        set
        {
            numberOfReviewsFieldSpecified = value;
        }
    }

    public int OverallRating
    {
        get
        {
            return overallRatingField;
        }
        set
        {
            overallRatingField = value;
        }
    }

    [XmlIgnore()]
    public bool OverallRatingSpecified
    {
        get
        {
            return overallRatingFieldSpecified;
        }
        set
        {
            overallRatingFieldSpecified = value;
        }
    }

    public string Url
    {
        get
        {
            return urlField;
        }
        set
        {
            urlField = value;
        }
    }

    public string Logo
    {
        get
        {
            return logoField;
        }
        set
        {
            logoField = value;
        }
    }

    public string EmailAddress
    {
        get
        {
            return emailAddressField;
        }
        set
        {
            emailAddressField = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return phoneNumberField;
        }
        set
        {
            phoneNumberField = value;
        }
    }

    public string AddressLine1
    {
        get
        {
            return addressLine1Field;
        }
        set
        {
            addressLine1Field = value;
        }
    }

    public string AddressLine2
    {
        get
        {
            return addressLine2Field;
        }
        set
        {
            addressLine2Field = value;
        }
    }
}

public partial class Promotion
{

    private string titleField;

    private string descriptionField;

    private string urlField;

    private string urlTextField;

    public string Title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }

    public string Description
    {
        get
        {
            return descriptionField;
        }
        set
        {
            descriptionField = value;
        }
    }

    public string Url
    {
        get
        {
            return urlField;
        }
        set
        {
            urlField = value;
        }
    }

    public string UrlText
    {
        get
        {
            return urlTextField;
        }
        set
        {
            urlTextField = value;
        }
    }
}

public partial class ParentCategory
{

    private string idField;

    private string nameField;

    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }
}

public partial class SellerList
{

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private string sellerIdField;

    private List<Product> productsField;

    public SellerList()
    {
        productsField = new List<Product>();
    }

    public long TotalResultSize
    {
        get
        {
            return totalResultSizeField;
        }
        set
        {
            totalResultSizeField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return totalResultSizeFieldSpecified;
        }
        set
        {
            totalResultSizeFieldSpecified = value;
        }
    }

    public string SellerId
    {
        get
        {
            return sellerIdField;
        }
        set
        {
            sellerIdField = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }
}

public partial class Pong
{

    private string messageField;

    public string Message
    {
        get
        {
            return messageField;
        }
        set
        {
            messageField = value;
        }
    }
}

public partial class ListResults
{

    private OriginalRequest originalRequestField;

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private List<Product> productsField;

    private List<Category> categoriesField;

    private List<RefinementGroup> refinementGroupsField;

    public ListResults()
    {
        refinementGroupsField = new List<RefinementGroup>();
        categoriesField = new List<Category>();
        productsField = new List<Product>();
        originalRequestField = new OriginalRequest();
    }

    public OriginalRequest OriginalRequest
    {
        get
        {
            return originalRequestField;
        }
        set
        {
            originalRequestField = value;
        }
    }

    public long TotalResultSize
    {
        get
        {
            return totalResultSizeField;
        }
        set
        {
            totalResultSizeField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return totalResultSizeFieldSpecified;
        }
        set
        {
            totalResultSizeFieldSpecified = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }

    public List<Category> Categories
    {
        get
        {
            return categoriesField;
        }
        set
        {
            categoriesField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return refinementGroupsField;
        }
        set
        {
            refinementGroupsField = value;
        }
    }
}

public partial class OriginalRequest
{

    private Category categoryField;

    private List<RefinementGroup> refinementGroupsField;

    public OriginalRequest()
    {
        refinementGroupsField = new List<RefinementGroup>();
        categoryField = new Category();
    }

    public Category Category
    {
        get
        {
            return categoryField;
        }
        set
        {
            categoryField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return refinementGroupsField;
        }
        set
        {
            refinementGroupsField = value;
        }
    }
}

public partial class Category
{

    private string idField;

    private string nameField;

    private int productCountField;

    private bool productCountFieldSpecified;

    private List<Refinement> refinementsField;

    public Category()
    {
        refinementsField = new List<Refinement>();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    public int ProductCount
    {
        get
        {
            return productCountField;
        }
        set
        {
            productCountField = value;
        }
    }

    [XmlIgnore()]
    public bool ProductCountSpecified
    {
        get
        {
            return productCountFieldSpecified;
        }
        set
        {
            productCountFieldSpecified = value;
        }
    }

    public List<Refinement> Refinements
    {
        get
        {
            return refinementsField;
        }
        set
        {
            refinementsField = value;
        }
    }
}

public partial class Refinement
{

    private string idField;

    private string nameField;

    private long productCountField;

    private bool productCountFieldSpecified;

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    public long ProductCount
    {
        get
        {
            return productCountField;
        }
        set
        {
            productCountField = value;
        }
    }

    [XmlIgnore()]
    public bool ProductCountSpecified
    {
        get
        {
            return productCountFieldSpecified;
        }
        set
        {
            productCountFieldSpecified = value;
        }
    }
}

public partial class RefinementGroup
{

    private string idField;

    private string nameField;

    private long productCountField;

    private bool productCountFieldSpecified;

    private bool multiSelectField;

    private bool multiSelectFieldSpecified;

    private List<Refinement> refinementsField;

    public RefinementGroup()
    {
        refinementsField = new List<Refinement>();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    public long ProductCount
    {
        get
        {
            return productCountField;
        }
        set
        {
            productCountField = value;
        }
    }

    [XmlIgnore()]
    public bool ProductCountSpecified
    {
        get
        {
            return productCountFieldSpecified;
        }
        set
        {
            productCountFieldSpecified = value;
        }
    }

    public bool MultiSelect
    {
        get
        {
            return multiSelectField;
        }
        set
        {
            multiSelectField = value;
        }
    }

    [XmlIgnore()]
    public bool MultiSelectSpecified
    {
        get
        {
            return multiSelectFieldSpecified;
        }
        set
        {
            multiSelectFieldSpecified = value;
        }
    }

    public List<Refinement> Refinements
    {
        get
        {
            return refinementsField;
        }
        set
        {
            refinementsField = value;
        }
    }
}

public partial class SearchResults
{

    private OriginalRequest originalRequestField;

    private long totalResultSizeField;

    private bool totalResultSizeFieldSpecified;

    private List<Product> productsField;

    private List<Category> categoriesField;

    private List<RefinementGroup> refinementGroupsField;

    public SearchResults()
    {
        refinementGroupsField = new List<RefinementGroup>();
        categoriesField = new List<Category>();
        productsField = new List<Product>();
        originalRequestField = new OriginalRequest();
    }

    public OriginalRequest OriginalRequest
    {
        get
        {
            return originalRequestField;
        }
        set
        {
            originalRequestField = value;
        }
    }

    public long TotalResultSize
    {
        get
        {
            return totalResultSizeField;
        }
        set
        {
            totalResultSizeField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalResultSizeSpecified
    {
        get
        {
            return totalResultSizeFieldSpecified;
        }
        set
        {
            totalResultSizeFieldSpecified = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }

    public List<Category> Categories
    {
        get
        {
            return categoriesField;
        }
        set
        {
            categoriesField = value;
        }
    }

    public List<RefinementGroup> RefinementGroups
    {
        get
        {
            return refinementGroupsField;
        }
        set
        {
            refinementGroupsField = value;
        }
    }
}

public partial class ProductOffers
{

    private OfferData offerDataField;

    public ProductOffers()
    {
        offerDataField = new OfferData();
    }

    public OfferData OfferData
    {
        get
        {
            return offerDataField;
        }
        set
        {
            offerDataField = value;
        }
    }
}

public partial class ProductRecommendations
{

    private List<Product> productsField;

    public ProductRecommendations()
    {
        productsField = new List<Product>();
    }

    public List<Product> Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }
}

public partial class Basket
{

    private double totalAmountArticlesField;

    private bool totalAmountArticlesFieldSpecified;

    private double subTotalField;

    private bool subTotalFieldSpecified;

    private double shippingFeeField;

    private bool shippingFeeFieldSpecified;

    private double totalField;

    private bool totalFieldSpecified;

    private double serviceFeeField;

    private bool serviceFeeFieldSpecified;

    private double giftWrapFeeField;

    private bool giftWrapFeeFieldSpecified;

    private Address billingAddressField;

    private Address shippingAddressField;

    private long totalQuantityField;

    private bool totalQuantityFieldSpecified;

    private bool shippableAbroadField;

    private bool shippableAbroadFieldSpecified;

    private bool combinableField;

    private bool combinableFieldSpecified;

    private bool openForUseField;

    private bool openForUseFieldSpecified;

    private List<string> specialRequirementsField;

    private List<string> basketMessagesField;

    private List<BasketItem> basketItemsField;

    private List<PricingAdjustment> pricingAdjustmentsField;

    public Basket()
    {
        pricingAdjustmentsField = new List<PricingAdjustment>();
        basketItemsField = new List<BasketItem>();
        basketMessagesField = new List<string>();
        specialRequirementsField = new List<string>();
        shippingAddressField = new Address();
        billingAddressField = new Address();
    }

    public double TotalAmountArticles
    {
        get
        {
            return totalAmountArticlesField;
        }
        set
        {
            totalAmountArticlesField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalAmountArticlesSpecified
    {
        get
        {
            return totalAmountArticlesFieldSpecified;
        }
        set
        {
            totalAmountArticlesFieldSpecified = value;
        }
    }

    public double SubTotal
    {
        get
        {
            return subTotalField;
        }
        set
        {
            subTotalField = value;
        }
    }

    [XmlIgnore()]
    public bool SubTotalSpecified
    {
        get
        {
            return subTotalFieldSpecified;
        }
        set
        {
            subTotalFieldSpecified = value;
        }
    }

    public double ShippingFee
    {
        get
        {
            return shippingFeeField;
        }
        set
        {
            shippingFeeField = value;
        }
    }

    [XmlIgnore()]
    public bool ShippingFeeSpecified
    {
        get
        {
            return shippingFeeFieldSpecified;
        }
        set
        {
            shippingFeeFieldSpecified = value;
        }
    }

    public double Total
    {
        get
        {
            return totalField;
        }
        set
        {
            totalField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalSpecified
    {
        get
        {
            return totalFieldSpecified;
        }
        set
        {
            totalFieldSpecified = value;
        }
    }

    public double ServiceFee
    {
        get
        {
            return serviceFeeField;
        }
        set
        {
            serviceFeeField = value;
        }
    }

    [XmlIgnore()]
    public bool ServiceFeeSpecified
    {
        get
        {
            return serviceFeeFieldSpecified;
        }
        set
        {
            serviceFeeFieldSpecified = value;
        }
    }

    public double GiftWrapFee
    {
        get
        {
            return giftWrapFeeField;
        }
        set
        {
            giftWrapFeeField = value;
        }
    }

    [XmlIgnore()]
    public bool GiftWrapFeeSpecified
    {
        get
        {
            return giftWrapFeeFieldSpecified;
        }
        set
        {
            giftWrapFeeFieldSpecified = value;
        }
    }

    public Address BillingAddress
    {
        get
        {
            return billingAddressField;
        }
        set
        {
            billingAddressField = value;
        }
    }

    public Address ShippingAddress
    {
        get
        {
            return shippingAddressField;
        }
        set
        {
            shippingAddressField = value;
        }
    }

    public long TotalQuantity
    {
        get
        {
            return totalQuantityField;
        }
        set
        {
            totalQuantityField = value;
        }
    }

    [XmlIgnore()]
    public bool TotalQuantitySpecified
    {
        get
        {
            return totalQuantityFieldSpecified;
        }
        set
        {
            totalQuantityFieldSpecified = value;
        }
    }

    public bool ShippableAbroad
    {
        get
        {
            return shippableAbroadField;
        }
        set
        {
            shippableAbroadField = value;
        }
    }

    [XmlIgnore()]
    public bool ShippableAbroadSpecified
    {
        get
        {
            return shippableAbroadFieldSpecified;
        }
        set
        {
            shippableAbroadFieldSpecified = value;
        }
    }

    public bool Combinable
    {
        get
        {
            return combinableField;
        }
        set
        {
            combinableField = value;
        }
    }

    [XmlIgnore()]
    public bool CombinableSpecified
    {
        get
        {
            return combinableFieldSpecified;
        }
        set
        {
            combinableFieldSpecified = value;
        }
    }

    public bool OpenForUse
    {
        get
        {
            return openForUseField;
        }
        set
        {
            openForUseField = value;
        }
    }

    [XmlIgnore()]
    public bool OpenForUseSpecified
    {
        get
        {
            return openForUseFieldSpecified;
        }
        set
        {
            openForUseFieldSpecified = value;
        }
    }

    public List<string> SpecialRequirements
    {
        get
        {
            return specialRequirementsField;
        }
        set
        {
            specialRequirementsField = value;
        }
    }

    public List<string> BasketMessages
    {
        get
        {
            return basketMessagesField;
        }
        set
        {
            basketMessagesField = value;
        }
    }

    public List<BasketItem> BasketItems
    {
        get
        {
            return basketItemsField;
        }
        set
        {
            basketItemsField = value;
        }
    }

    public List<PricingAdjustment> PricingAdjustments
    {
        get
        {
            return pricingAdjustmentsField;
        }
        set
        {
            pricingAdjustmentsField = value;
        }
    }
}

public partial class Address
{

    private string idField;

    private string genderField;

    private string firstNameField;

    private string lastNameField;

    private string infixField;

    private string companyNameField;

    private string cityField;

    private string countryField;

    private string countyField;

    private string houseNumberExtField;

    private string houseNumberField;

    private string postalCodeField;

    private string streetNameField;

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public string Gender
    {
        get
        {
            return genderField;
        }
        set
        {
            genderField = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstNameField;
        }
        set
        {
            firstNameField = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastNameField;
        }
        set
        {
            lastNameField = value;
        }
    }

    public string Infix
    {
        get
        {
            return infixField;
        }
        set
        {
            infixField = value;
        }
    }

    public string CompanyName
    {
        get
        {
            return companyNameField;
        }
        set
        {
            companyNameField = value;
        }
    }

    public string City
    {
        get
        {
            return cityField;
        }
        set
        {
            cityField = value;
        }
    }

    public string Country
    {
        get
        {
            return countryField;
        }
        set
        {
            countryField = value;
        }
    }

    public string County
    {
        get
        {
            return countyField;
        }
        set
        {
            countyField = value;
        }
    }

    public string HouseNumberExt
    {
        get
        {
            return houseNumberExtField;
        }
        set
        {
            houseNumberExtField = value;
        }
    }

    public string HouseNumber
    {
        get
        {
            return houseNumberField;
        }
        set
        {
            houseNumberField = value;
        }
    }

    public string PostalCode
    {
        get
        {
            return postalCodeField;
        }
        set
        {
            postalCodeField = value;
        }
    }

    public string StreetName
    {
        get
        {
            return streetNameField;
        }
        set
        {
            streetNameField = value;
        }
    }
}

public partial class BasketItem
{

    private string idField;

    private double priceField;

    private bool priceFieldSpecified;

    private long quantityField;

    private bool quantityFieldSpecified;

    private string conditionField;

    private double listPriceField;

    private bool listPriceFieldSpecified;

    private string availabilityCodeField;

    private string availabilityDescriptionField;

    private string commentField;

    private bool secondHandField;

    private bool secondHandFieldSpecified;

    private Seller sellerField;

    private Product productField;

    public BasketItem()
    {
        productField = new Product();
        sellerField = new Seller();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public double Price
    {
        get
        {
            return priceField;
        }
        set
        {
            priceField = value;
        }
    }

    [XmlIgnore()]
    public bool PriceSpecified
    {
        get
        {
            return priceFieldSpecified;
        }
        set
        {
            priceFieldSpecified = value;
        }
    }

    public long Quantity
    {
        get
        {
            return quantityField;
        }
        set
        {
            quantityField = value;
        }
    }

    [XmlIgnore()]
    public bool QuantitySpecified
    {
        get
        {
            return quantityFieldSpecified;
        }
        set
        {
            quantityFieldSpecified = value;
        }
    }

    public string Condition
    {
        get
        {
            return conditionField;
        }
        set
        {
            conditionField = value;
        }
    }

    public double ListPrice
    {
        get
        {
            return listPriceField;
        }
        set
        {
            listPriceField = value;
        }
    }

    [XmlIgnore()]
    public bool ListPriceSpecified
    {
        get
        {
            return listPriceFieldSpecified;
        }
        set
        {
            listPriceFieldSpecified = value;
        }
    }

    public string AvailabilityCode
    {
        get
        {
            return availabilityCodeField;
        }
        set
        {
            availabilityCodeField = value;
        }
    }

    public string AvailabilityDescription
    {
        get
        {
            return availabilityDescriptionField;
        }
        set
        {
            availabilityDescriptionField = value;
        }
    }

    public string Comment
    {
        get
        {
            return commentField;
        }
        set
        {
            commentField = value;
        }
    }

    public bool SecondHand
    {
        get
        {
            return secondHandField;
        }
        set
        {
            secondHandField = value;
        }
    }

    [XmlIgnore()]
    public bool SecondHandSpecified
    {
        get
        {
            return secondHandFieldSpecified;
        }
        set
        {
            secondHandFieldSpecified = value;
        }
    }

    public Seller Seller
    {
        get
        {
            return sellerField;
        }
        set
        {
            sellerField = value;
        }
    }

    public Product Product
    {
        get
        {
            return productField;
        }
        set
        {
            productField = value;
        }
    }
}

public partial class PricingAdjustment
{

    private string descriptionField;

    private double amountField;

    private bool revocableField;

    public string Description
    {
        get
        {
            return descriptionField;
        }
        set
        {
            descriptionField = value;
        }
    }

    public double Amount
    {
        get
        {
            return amountField;
        }
        set
        {
            amountField = value;
        }
    }

    public bool Revocable
    {
        get
        {
            return revocableField;
        }
        set
        {
            revocableField = value;
        }
    }
}

public partial class Error
{

    private string codeField;

    private string messageField;

    public string Code
    {
        get
        {
            return codeField;
        }
        set
        {
            codeField = value;
        }
    }

    public string Message
    {
        get
        {
            return messageField;
        }
        set
        {
            messageField = value;
        }
    }
}

public partial class WishList
{

    private List<WishListItem> wishListItemsField;

    public WishList()
    {
        wishListItemsField = new List<WishListItem>();
    }

    public List<WishListItem> WishListItems
    {
        get
        {
            return wishListItemsField;
        }
        set
        {
            wishListItemsField = value;
        }
    }
}

public partial class WishListItem
{

    private string idField;

    private Product productField;

    public WishListItem()
    {
        productField = new Product();
    }

    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    public Product Product
    {
        get
        {
            return productField;
        }
        set
        {
            productField = value;
        }
    }
}

public partial class RelatedProducts
{

    private List<ProductFamily> productFamiliesField;

    private List<Accessory> accessoriesField;

    public RelatedProducts()
    {
        accessoriesField = new List<Accessory>();
        productFamiliesField = new List<ProductFamily>();
    }

    public List<ProductFamily> ProductFamilies
    {
        get
        {
            return productFamiliesField;
        }
        set
        {
            productFamiliesField = value;
        }
    }

    public List<Accessory> Accessories
    {
        get
        {
            return accessoriesField;
        }
        set
        {
            accessoriesField = value;
        }
    }
}

public partial class ProductFamily
{

    private string keyField;

    private string labelField;

    private List<ProductFamilyMember> productFamilyMembersField;

    public ProductFamily()
    {
        productFamilyMembersField = new List<ProductFamilyMember>();
    }

    public string Key
    {
        get
        {
            return keyField;
        }
        set
        {
            keyField = value;
        }
    }

    public string Label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }

    public List<ProductFamilyMember> ProductFamilyMembers
    {
        get
        {
            return productFamilyMembersField;
        }
        set
        {
            productFamilyMembersField = value;
        }
    }
}

public partial class ProductFamilyMember
{

    private string labelField;

    private string productIdField;

    public string Label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }

    public string productId
    {
        get
        {
            return productIdField;
        }
        set
        {
            productIdField = value;
        }
    }
}

public partial class Accessory
{

    private string productIdField;

    public string productId
    {
        get
        {
            return productIdField;
        }
        set
        {
            productIdField = value;
        }
    }
}

public partial class ParentCategoryPaths
{

    private List<ParentCategory> parentCategoriesField;

    public ParentCategoryPaths()
    {
        parentCategoriesField = new List<ParentCategory>();
    }

    public List<ParentCategory> ParentCategories
    {
        get
        {
            return parentCategoriesField;
        }
        set
        {
            parentCategoriesField = value;
        }
    }
}
