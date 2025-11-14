using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I841 - .
/// </summary>
public class F75I841 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARDOC.
        /// </summary>
        public const string ARDOC = "ARDOC";

        /// <summary>
        /// ARDCT.
        /// </summary>
        public const string ARDCT = "ARDCT";

        /// <summary>
        /// ARKCO.
        /// </summary>
        public const string ARKCO = "ARKCO";

        /// <summary>
        /// ARSFX.
        /// </summary>
        public const string ARSFX = "ARSFX";

        /// <summary>
        /// ARPYID.
        /// </summary>
        public const string ARPYID = "ARPYID";

        /// <summary>
        /// ARRC5.
        /// </summary>
        public const string ARRC5 = "ARRC5";

        /// <summary>
        /// ARCKNU.
        /// </summary>
        public const string ARCKNU = "ARCKNU";

        /// <summary>
        /// ARI75INVNO.
        /// </summary>
        public const string ARI75INVNO = "ARI75INVNO";

        /// <summary>
        /// ARI75IGSTA.
        /// </summary>
        public const string ARI75IGSTA = "ARI75IGSTA";

        /// <summary>
        /// ARI75CGSTA.
        /// </summary>
        public const string ARI75CGSTA = "ARI75CGSTA";

        /// <summary>
        /// ARI75SGSTA.
        /// </summary>
        public const string ARI75SGSTA = "ARI75SGSTA";

        /// <summary>
        /// ARI75CESSA.
        /// </summary>
        public const string ARI75CESSA = "ARI75CESSA";

        /// <summary>
        /// ARI75ATX2A.
        /// </summary>
        public const string ARI75ATX2A = "ARI75ATX2A";

        /// <summary>
        /// ARI75ATX1A.
        /// </summary>
        public const string ARI75ATX1A = "ARI75ATX1A";

        /// <summary>
        /// ARI75ATX3A.
        /// </summary>
        public const string ARI75ATX3A = "ARI75ATX3A";

        /// <summary>
        /// ARI75AT4A.
        /// </summary>
        public const string ARI75AT4A = "ARI75AT4A";

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

        /// <summary>
        /// ARYNUM1.
        /// </summary>
        public const string ARYNUM1 = "ARYNUM1";

        /// <summary>
        /// ARICU.
        /// </summary>
        public const string ARICU = "ARICU";

        /// <summary>
        /// ARICUT.
        /// </summary>
        public const string ARICUT = "ARICUT";

        /// <summary>
        /// ARDE.
        /// </summary>
        public const string ARDE = "ARDE";
    }

    /// <inheritdoc />
    public override string TableName => "F75I841";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARDOC", "ARDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ARDCT", "ARDCT", JdeDataType.String, 4, true, true),
        new JdeField("ARKCO", "ARKCO", JdeDataType.String, 10, true, true),
        new JdeField("ARSFX", "ARSFX", JdeDataType.String, 6, true, true),
        new JdeField("ARPYID", "ARPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("ARRC5", "ARRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("ARCKNU", "ARCKNU", JdeDataType.String, 50),
        new JdeField("ARI75INVNO", "ARI75INVNO", JdeDataType.String, 50),
        new JdeField("ARI75IGSTA", "ARI75IGSTA", JdeDataType.Numeric),
        new JdeField("ARI75CGSTA", "ARI75CGSTA", JdeDataType.Numeric),
        new JdeField("ARI75SGSTA", "ARI75SGSTA", JdeDataType.Numeric),
        new JdeField("ARI75CESSA", "ARI75CESSA", JdeDataType.Numeric),
        new JdeField("ARI75ATX2A", "ARI75ATX2A", JdeDataType.Numeric),
        new JdeField("ARI75ATX1A", "ARI75ATX1A", JdeDataType.Numeric),
        new JdeField("ARI75ATX3A", "ARI75ATX3A", JdeDataType.Numeric),
        new JdeField("ARI75AT4A", "ARI75AT4A", JdeDataType.Numeric),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric),
        new JdeField("ARYFUTDT1", "ARYFUTDT1", JdeDataType.Numeric),
        new JdeField("ARFUT6", "ARFUT6", JdeDataType.String, 60),
        new JdeField("ARYT04", "ARYT04", JdeDataType.String, 2),
        new JdeField("ARYFLAG", "ARYFLAG", JdeDataType.String, 2),
        new JdeField("ARYNUM1", "ARYNUM1", JdeDataType.Numeric),
        new JdeField("ARICU", "ARICU", JdeDataType.Numeric),
        new JdeField("ARICUT", "ARICUT", JdeDataType.String, 4),
        new JdeField("ARDE", "ARDE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I841_0", "Primary Key on ARDOC, ARDCT, ARKCO, ARSFX, ARPYID, ARRC5", new[] { "ARDOC", "ARDCT", "ARKCO", "ARSFX", "ARPYID", "ARRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I841_2", "Index on ARPYID, ARRC5", new[] { "ARPYID", "ARRC5" })
    };
}
