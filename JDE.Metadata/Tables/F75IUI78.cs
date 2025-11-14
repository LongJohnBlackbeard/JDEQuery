using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI78 - .
/// </summary>
public class F75IUI78 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARJOBS.
        /// </summary>
        public const string ARJOBS = "ARJOBS";

        /// <summary>
        /// ARUKID.
        /// </summary>
        public const string ARUKID = "ARUKID";

        /// <summary>
        /// ARPYID.
        /// </summary>
        public const string ARPYID = "ARPYID";

        /// <summary>
        /// ARI75GSTRA.
        /// </summary>
        public const string ARI75GSTRA = "ARI75GSTRA";

        /// <summary>
        /// ARAG.
        /// </summary>
        public const string ARAG = "ARAG";

        /// <summary>
        /// ARI75IPOS.
        /// </summary>
        public const string ARI75IPOS = "ARI75IPOS";

        /// <summary>
        /// ARI75TRCAT.
        /// </summary>
        public const string ARI75TRCAT = "ARI75TRCAT";

        /// <summary>
        /// ARI75CGSTA.
        /// </summary>
        public const string ARI75CGSTA = "ARI75CGSTA";

        /// <summary>
        /// ARI75SGSTA.
        /// </summary>
        public const string ARI75SGSTA = "ARI75SGSTA";

        /// <summary>
        /// ARI75IGSTA.
        /// </summary>
        public const string ARI75IGSTA = "ARI75IGSTA";

        /// <summary>
        /// ARI75CESSA.
        /// </summary>
        public const string ARI75CESSA = "ARI75CESSA";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";

        /// <summary>
        /// ARYFUTDT1.
        /// </summary>
        public const string ARYFUTDT1 = "ARYFUTDT1";

        /// <summary>
        /// ARFUT6.
        /// </summary>
        public const string ARFUT6 = "ARFUT6";

        /// <summary>
        /// ARYT04.
        /// </summary>
        public const string ARYT04 = "ARYT04";

        /// <summary>
        /// ARYFLAG.
        /// </summary>
        public const string ARYFLAG = "ARYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI78";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARJOBS", "ARJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ARUKID", "ARUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ARPYID", "ARPYID", JdeDataType.Numeric),
        new JdeField("ARI75GSTRA", "ARI75GSTRA", JdeDataType.String, 4),
        new JdeField("ARAG", "ARAG", JdeDataType.Numeric),
        new JdeField("ARI75IPOS", "ARI75IPOS", JdeDataType.String, 4),
        new JdeField("ARI75TRCAT", "ARI75TRCAT", JdeDataType.String, 4),
        new JdeField("ARI75CGSTA", "ARI75CGSTA", JdeDataType.Numeric),
        new JdeField("ARI75SGSTA", "ARI75SGSTA", JdeDataType.Numeric),
        new JdeField("ARI75IGSTA", "ARI75IGSTA", JdeDataType.Numeric),
        new JdeField("ARI75CESSA", "ARI75CESSA", JdeDataType.Numeric),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric),
        new JdeField("ARYFUTDT1", "ARYFUTDT1", JdeDataType.Numeric),
        new JdeField("ARFUT6", "ARFUT6", JdeDataType.String, 60),
        new JdeField("ARYT04", "ARYT04", JdeDataType.String, 2),
        new JdeField("ARYFLAG", "ARYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI78_0", "Primary Key on ARJOBS, ARUKID", new[] { "ARJOBS", "ARUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
