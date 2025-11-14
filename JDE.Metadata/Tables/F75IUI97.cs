using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI97 - .
/// </summary>
public class F75IUI97 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIJOBS.
        /// </summary>
        public const string OIJOBS = "OIJOBS";

        /// <summary>
        /// OIUKID.
        /// </summary>
        public const string OIUKID = "OIUKID";

        /// <summary>
        /// OII75GSTNP.
        /// </summary>
        public const string OII75GSTNP = "OII75GSTNP";

        /// <summary>
        /// OII75GSTR.
        /// </summary>
        public const string OII75GSTR = "OII75GSTR";

        /// <summary>
        /// OII75GSTRA.
        /// </summary>
        public const string OII75GSTRA = "OII75GSTRA";

        /// <summary>
        /// OIATXA.
        /// </summary>
        public const string OIATXA = "OIATXA";

        /// <summary>
        /// OII75IGSTA.
        /// </summary>
        public const string OII75IGSTA = "OII75IGSTA";

        /// <summary>
        /// OII75CGSTA.
        /// </summary>
        public const string OII75CGSTA = "OII75CGSTA";

        /// <summary>
        /// OII75SGSTA.
        /// </summary>
        public const string OII75SGSTA = "OII75SGSTA";

        /// <summary>
        /// OII75CESSA.
        /// </summary>
        public const string OII75CESSA = "OII75CESSA";

        /// <summary>
        /// OII75CATTY.
        /// </summary>
        public const string OII75CATTY = "OII75CATTY";

        /// <summary>
        /// OII75CATVL.
        /// </summary>
        public const string OII75CATVL = "OII75CATVL";

        /// <summary>
        /// OII75FRC.
        /// </summary>
        public const string OII75FRC = "OII75FRC";

        /// <summary>
        /// OII75IPOS.
        /// </summary>
        public const string OII75IPOS = "OII75IPOS";

        /// <summary>
        /// OII75TRCAT.
        /// </summary>
        public const string OII75TRCAT = "OII75TRCAT";

        /// <summary>
        /// OII75EXCAT.
        /// </summary>
        public const string OII75EXCAT = "OII75EXCAT";

        /// <summary>
        /// OII75EXTYP.
        /// </summary>
        public const string OII75EXTYP = "OII75EXTYP";

        /// <summary>
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OIDFYN.
        /// </summary>
        public const string OIDFYN = "OIDFYN";

        /// <summary>
        /// OIAPGM.
        /// </summary>
        public const string OIAPGM = "OIAPGM";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OIUPMT.
        /// </summary>
        public const string OIUPMT = "OIUPMT";

        /// <summary>
        /// OIYFUTDT.
        /// </summary>
        public const string OIYFUTDT = "OIYFUTDT";

        /// <summary>
        /// OIFFU4.
        /// </summary>
        public const string OIFFU4 = "OIFFU4";

        /// <summary>
        /// OIFUT3.
        /// </summary>
        public const string OIFUT3 = "OIFUT3";

        /// <summary>
        /// OIX2.
        /// </summary>
        public const string OIX2 = "OIX2";

        /// <summary>
        /// OIFUTCH1.
        /// </summary>
        public const string OIFUTCH1 = "OIFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI97";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIJOBS", "OIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OIUKID", "OIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OII75GSTNP", "OII75GSTNP", JdeDataType.String, 50),
        new JdeField("OII75GSTR", "OII75GSTR", JdeDataType.Numeric),
        new JdeField("OII75GSTRA", "OII75GSTRA", JdeDataType.String, 4),
        new JdeField("OIATXA", "OIATXA", JdeDataType.Numeric),
        new JdeField("OII75IGSTA", "OII75IGSTA", JdeDataType.Numeric),
        new JdeField("OII75CGSTA", "OII75CGSTA", JdeDataType.Numeric),
        new JdeField("OII75SGSTA", "OII75SGSTA", JdeDataType.Numeric),
        new JdeField("OII75CESSA", "OII75CESSA", JdeDataType.Numeric),
        new JdeField("OII75CATTY", "OII75CATTY", JdeDataType.String, 6),
        new JdeField("OII75CATVL", "OII75CATVL", JdeDataType.String, 40),
        new JdeField("OII75FRC", "OII75FRC", JdeDataType.String, 2),
        new JdeField("OII75IPOS", "OII75IPOS", JdeDataType.String, 4),
        new JdeField("OII75TRCAT", "OII75TRCAT", JdeDataType.String, 4),
        new JdeField("OII75EXCAT", "OII75EXCAT", JdeDataType.String, 4),
        new JdeField("OII75EXTYP", "OII75EXTYP", JdeDataType.String, 10),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OIDFYN", "OIDFYN", JdeDataType.Numeric),
        new JdeField("OIAPGM", "OIAPGM", JdeDataType.String, 20),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OIUPMT", "OIUPMT", JdeDataType.Numeric),
        new JdeField("OIYFUTDT", "OIYFUTDT", JdeDataType.Numeric),
        new JdeField("OIFFU4", "OIFFU4", JdeDataType.Numeric),
        new JdeField("OIFUT3", "OIFUT3", JdeDataType.String, 60),
        new JdeField("OIX2", "OIX2", JdeDataType.String, 2),
        new JdeField("OIFUTCH1", "OIFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI97_0", "Primary Key on OIJOBS, OIUKID", new[] { "OIJOBS", "OIUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
