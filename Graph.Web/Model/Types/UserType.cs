using HotChocolate.Types;

namespace Graph.Web.Model.Types
{
        public class UserType : ObjectType<User>
        {
                protected override void Configure(IObjectTypeDescriptor<User> descriptor)
                {
                        descriptor.Field(op => op.Username)
                                .Type<StringType>();

                        descriptor.Field(op => op.Id)
                               .Type<StringType>();

                        descriptor.Field(op => op.CreationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.ModificationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.Likes)
                                .Type<ListType<LikeType>>();

                        //descriptor.Field(op => op.Comments)
                        //        .Type<CommentType>();

                        //descriptor.Field(op => op.Posts)
                        //        .Type<PostType>();


                }
        }
}
