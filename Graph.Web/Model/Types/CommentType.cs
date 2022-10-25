namespace Graph.Web.Model.Types
{
        public class CommentType : ObjectType<Comment>
        {
                protected override void Configure(IObjectTypeDescriptor<Comment> descriptor)
                {
                        descriptor.Field(op => op.UserId)
                                .Type<StringType>();

                        descriptor.Field(op => op.ParentId)
                                .Type<StringType>();

                        descriptor.Field(op => op.PostId)
                                .Type<StringType>();

                        descriptor.Field(op => op.User)
                                .Type<ObjectType<User>>();

                        descriptor.Field(op => op.Parent)
                                .Type<ObjectType<Comment>>();

                        descriptor.Field(op => op.CommentLikes)
                                .Type<LikeType>();

                        descriptor.Field(op => op.Post)
                                .Type<ObjectType<Post>>();

                        descriptor.Field(op => op.LikeCount)
                                .Type<LongType>();

                        descriptor.Field(op => op.CreationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.ModificationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.Id)
                               .Type<StringType>();



                }
        }
}
