using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I403T - .
/// </summary>
public class F75I403T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABKCOO.
        /// </summary>
        public const string ABKCOO = "ABKCOO";

        /// <summary>
        /// ABDOCO.
        /// </summary>
        public const string ABDOCO = "ABDOCO";

        /// <summary>
        /// ABDCTO.
        /// </summary>
        public const string ABDCTO = "ABDCTO";

        /// <summary>
        /// ABLNID.
        /// </summary>
        public const string ABLNID = "ABLNID";

        /// <summary>
        /// ABKCO.
        /// </summary>
        public const string ABKCO = "ABKCO";

        /// <summary>
        /// ABDOC.
        /// </summary>
        public const string ABDOC = "ABDOC";

        /// <summary>
        /// ABDCT.
        /// </summary>
        public const string ABDCT = "ABDCT";

        /// <summary>
        /// ABCO.
        /// </summary>
        public const string ABCO = "ABCO";

        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABAREC.
        /// </summary>
        public const string ABAREC = "ABAREC";

        /// <summary>
        /// ABAPTD.
        /// </summary>
        public const string ABAPTD = "ABAPTD";

        /// <summary>
        /// ABLOTN.
        /// </summary>
        public const string ABLOTN = "ABLOTN";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABDOC1.
        /// </summary>
        public const string ABDOC1 = "ABDOC1";

        /// <summary>
        /// ABDCT1.
        /// </summary>
        public const string ABDCT1 = "ABDCT1";

        /// <summary>
        /// ABLNIX.
        /// </summary>
        public const string ABLNIX = "ABLNIX";

        /// <summary>
        /// ABQTYS.
        /// </summary>
        public const string ABQTYS = "ABQTYS";

        /// <summary>
        /// ABSOQS.
        /// </summary>
        public const string ABSOQS = "ABSOQS";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";

        /// <summary>
        /// ABLITM.
        /// </summary>
        public const string ABLITM = "ABLITM";

        /// <summary>
        /// ABTORG.
        /// </summary>
        public const string ABTORG = "ABTORG";

        /// <summary>
        /// ABADSO.
        /// </summary>
        public const string ABADSO = "ABADSO";

        /// <summary>
        /// ABLOCN.
        /// </summary>
        public const string ABLOCN = "ABLOCN";

        /// <summary>
        /// ABVSFST.
        /// </summary>
        public const string ABVSFST = "ABVSFST";

        /// <summary>
        /// ABIVD.
        /// </summary>
        public const string ABIVD = "ABIVD";

        /// <summary>
        /// ABAEXP.
        /// </summary>
        public const string ABAEXP = "ABAEXP";

        /// <summary>
        /// ABAG.
        /// </summary>
        public const string ABAG = "ABAG";

        /// <summary>
        /// ABDGL.
        /// </summary>
        public const string ABDGL = "ABDGL";

        /// <summary>
        /// ABTRDJ.
        /// </summary>
        public const string ABTRDJ = "ABTRDJ";

        /// <summary>
        /// ABPCST.
        /// </summary>
        public const string ABPCST = "ABPCST";

        /// <summary>
        /// ABADDS.
        /// </summary>
        public const string ABADDS = "ABADDS";

        /// <summary>
        /// ABMCU1.
        /// </summary>
        public const string ABMCU1 = "ABMCU1";

        /// <summary>
        /// ABQTYW.
        /// </summary>
        public const string ABQTYW = "ABQTYW";
    }

    /// <inheritdoc />
    public override string TableName => "F75I403T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABKCOO", "ABKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ABDOCO", "ABDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ABDCTO", "ABDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ABLNID", "ABLNID", JdeDataType.Numeric),
        new JdeField("ABKCO", "ABKCO", JdeDataType.String, 10),
        new JdeField("ABDOC", "ABDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ABDCT", "ABDCT", JdeDataType.String, 4),
        new JdeField("ABCO", "ABCO", JdeDataType.String, 10),
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24),
        new JdeField("ABAREC", "ABAREC", JdeDataType.Numeric),
        new JdeField("ABAPTD", "ABAPTD", JdeDataType.Numeric),
        new JdeField("ABLOTN", "ABLOTN", JdeDataType.String, 60),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20, true, true),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABDOC1", "ABDOC1", JdeDataType.Numeric, null, true, true),
        new JdeField("ABDCT1", "ABDCT1", JdeDataType.String, 4, true, true),
        new JdeField("ABLNIX", "ABLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("ABQTYS", "ABQTYS", JdeDataType.Numeric),
        new JdeField("ABSOQS", "ABSOQS", JdeDataType.Numeric),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric),
        new JdeField("ABLITM", "ABLITM", JdeDataType.String, 50),
        new JdeField("ABTORG", "ABTORG", JdeDataType.String, 20),
        new JdeField("ABADSO", "ABADSO", JdeDataType.String, 6),
        new JdeField("ABLOCN", "ABLOCN", JdeDataType.String, 40),
        new JdeField("ABVSFST", "ABVSFST", JdeDataType.String, 6),
        new JdeField("ABIVD", "ABIVD", JdeDataType.Numeric),
        new JdeField("ABAEXP", "ABAEXP", JdeDataType.Numeric),
        new JdeField("ABAG", "ABAG", JdeDataType.Numeric),
        new JdeField("ABDGL", "ABDGL", JdeDataType.Numeric),
        new JdeField("ABTRDJ", "ABTRDJ", JdeDataType.Numeric),
        new JdeField("ABPCST", "ABPCST", JdeDataType.Numeric),
        new JdeField("ABADDS", "ABADDS", JdeDataType.String, 6),
        new JdeField("ABMCU1", "ABMCU1", JdeDataType.String, 24),
        new JdeField("ABQTYW", "ABQTYW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I403T_0", "Primary Key on ABUSER, ABKCOO, ABDOCO, ABDCTO, ABDOC, ABDOC1, ABDCT1, ABLNIX", new[] { "ABUSER", "ABKCOO", "ABDOCO", "ABDCTO", "ABDOC", "ABDOC1", "ABDCT1", "ABLNIX" }, isUnique: true, isPrimaryKey: true)
    };
}
