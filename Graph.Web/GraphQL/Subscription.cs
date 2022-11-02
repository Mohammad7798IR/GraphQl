using Graph.Web.Model;

namespace Graph.Web.GraphQL;
public class Subscription
{

        [Topic]
        [Subscribe]
        public Post OnPostAdded([EventMessage] Post post) => post;
}
