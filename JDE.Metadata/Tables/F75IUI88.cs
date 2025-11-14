using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI88 - .
/// </summary>
public class F75IUI88 : JdeTable
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
        /// ARPYID.
        /// </summary>
        public const string ARPYID = "ARPYID";

        /// <summary>
        /// ARRC5.
        /// </summary>
        public const string ARRC5 = "ARRC5";

        /// <summary>
        /// ARCO.
        /// </summary>
        public const string ARCO = "ARCO";

        /// <summary>
        /// ARAN8.
        /// </summary>
        public const string ARAN8 = "ARAN8";

        /// <summary>
        /// ARCKNU.
        /// </summary>
        public const string ARCKNU = "ARCKNU";

        /// <summary>
        /// ARI75CATTY.
        /// </summary>
        public const string ARI75CATTY = "ARI75CATTY";

        /// <summary>
        /// ARI75CATVL.
        /// </summary>
        public const string ARI75CATVL = "ARI75CATVL";

        /// <summary>
        /// ARI75CATCO.
        /// </summary>
        public const string ARI75CATCO = "ARI75CATCO";

        /// <summary>
        /// ARAG.
        /// </summary>
        public const string ARAG = "ARAG";

        /// <summary>
        /// ARATXA.
        /// </summary>
        public const string ARATXA = "ARATXA";

        /// <summary>
        /// ARSTAM.
        /// </summary>
        public const string ARSTAM = "ARSTAM";

        /// <summary>
        /// ARI75IGSTA.
        /// </summary>
        public const string ARI75IGSTA = "ARI75IGSTA";

        /// <summary>
        /// ARI75IGSTO.
        /// </summary>
        public const string ARI75IGSTO = "ARI75IGSTO";

        /// <summary>
        /// ARI75CGSTA.
        /// </summary>
        public const string ARI75CGSTA = "ARI75CGSTA";

        /// <summary>
        /// ARI75CGSTO.
        /// </summary>
        public const string ARI75CGSTO = "ARI75CGSTO";

        /// <summary>
        /// ARI75SGSTA.
        /// </summary>
        public const string ARI75SGSTA = "ARI75SGSTA";

        /// <summary>
        /// ARI75SGSTO.
        /// </summary>
        public const string ARI75SGSTO = "ARI75SGSTO";

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
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

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
        /// ARI75CESSA.
        /// </summary>
        public const string ARI75CESSA = "ARI75CESSA";

        /// <summary>
        /// ARI75CESSO.
        /// </summary>
        public const string ARI75CESSO = "ARI75CESSO";

        /// <summary>
        /// ARI75ATX1A.
        /// </summary>
        public const string ARI75ATX1A = "ARI75ATX1A";

        /// <summary>
        /// ARI75ATX1O.
        /// </summary>
        public const string ARI75ATX1O = "ARI75ATX1O";

        /// <summary>
        /// ARI75ATX2A.
        /// </summary>
        public const string ARI75ATX2A = "ARI75ATX2A";

        /// <summary>
        /// ARI75ATX2O.
        /// </summary>
        public const string ARI75ATX2O = "ARI75ATX2O";

        /// <summary>
        /// ARI75ATX3A.
        /// </summary>
        public const string ARI75ATX3A = "ARI75ATX3A";

        /// <summary>
        /// ARI75ATX3O.
        /// </summary>
        public const string ARI75ATX3O = "ARI75ATX3O";

        /// <summary>
        /// ARI75AT4A.
        /// </summary>
        public const string ARI75AT4A = "ARI75AT4A";

        /// <summary>
        /// ARI75AT4O.
        /// </summary>
        public const string ARI75AT4O = "ARI75AT4O";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI88";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARJOBS", "ARJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ARPYID", "ARPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("ARRC5", "ARRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("ARCO", "ARCO", JdeDataType.String, 10),
        new JdeField("ARAN8", "ARAN8", JdeDataType.Numeric),
        new JdeField("ARCKNU", "ARCKNU", JdeDataType.String, 50),
        new JdeField("ARI75CATTY", "ARI75CATTY", JdeDataType.String, 6),
        new JdeField("ARI75CATVL", "ARI75CATVL", JdeDataType.String, 40, true, true),
        new JdeField("ARI75CATCO", "ARI75CATCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ARAG", "ARAG", JdeDataType.Numeric),
        new JdeField("ARATXA", "ARATXA", JdeDataType.Numeric),
        new JdeField("ARSTAM", "ARSTAM", JdeDataType.Numeric),
        new JdeField("ARI75IGSTA", "ARI75IGSTA", JdeDataType.Numeric),
        new JdeField("ARI75IGSTO", "ARI75IGSTO", JdeDataType.Numeric),
        new JdeField("ARI75CGSTA", "ARI75CGSTA", JdeDataType.Numeric),
        new JdeField("ARI75CGSTO", "ARI75CGSTO", JdeDataType.Numeric),
        new JdeField("ARI75SGSTA", "ARI75SGSTA", JdeDataType.Numeric),
        new JdeField("ARI75SGSTO", "ARI75SGSTO", JdeDataType.Numeric),
        new JdeField("ARYFUTDT1", "ARYFUTDT1", JdeDataType.Numeric),
        new JdeField("ARFUT6", "ARFUT6", JdeDataType.String, 60),
        new JdeField("ARYT04", "ARYT04", JdeDataType.String, 2),
        new JdeField("ARYFLAG", "ARYFLAG", JdeDataType.String, 2),
        new JdeField("ARYNUM1", "ARYNUM1", JdeDataType.Numeric),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20, true, true),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric),
        new JdeField("ARI75CESSA", "ARI75CESSA", JdeDataType.Numeric),
        new JdeField("ARI75CESSO", "ARI75CESSO", JdeDataType.Numeric),
        new JdeField("ARI75ATX1A", "ARI75ATX1A", JdeDataType.Numeric),
        new JdeField("ARI75ATX1O", "ARI75ATX1O", JdeDataType.Numeric),
        new JdeField("ARI75ATX2A", "ARI75ATX2A", JdeDataType.Numeric),
        new JdeField("ARI75ATX2O", "ARI75ATX2O", JdeDataType.Numeric),
        new JdeField("ARI75ATX3A", "ARI75ATX3A", JdeDataType.Numeric),
        new JdeField("ARI75ATX3O", "ARI75ATX3O", JdeDataType.Numeric),
        new JdeField("ARI75AT4A", "ARI75AT4A", JdeDataType.Numeric),
        new JdeField("ARI75AT4O", "ARI75AT4O", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI88_0", "Primary Key on ARPYID, ARRC5, ARJOBS, ARUSER, ARI75CATVL, ARI75CATCO", new[] { "ARPYID", "ARRC5", "ARJOBS", "ARUSER", "ARI75CATVL", "ARI75CATCO" }, isUnique: true, isPrimaryKey: true)
    };
}
