using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I869 - .
/// </summary>
public class F75I869 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGPRNB.
        /// </summary>
        public const string RGPRNB = "RGPRNB";

        /// <summary>
        /// RGLNMB.
        /// </summary>
        public const string RGLNMB = "RGLNMB";

        /// <summary>
        /// RGEFTJ.
        /// </summary>
        public const string RGEFTJ = "RGEFTJ";

        /// <summary>
        /// RGI75CGSTR.
        /// </summary>
        public const string RGI75CGSTR = "RGI75CGSTR";

        /// <summary>
        /// RGI75SGSTR.
        /// </summary>
        public const string RGI75SGSTR = "RGI75SGSTR";

        /// <summary>
        /// RGI75IGSTR.
        /// </summary>
        public const string RGI75IGSTR = "RGI75IGSTR";

        /// <summary>
        /// RGI75CESSR.
        /// </summary>
        public const string RGI75CESSR = "RGI75CESSR";

        /// <summary>
        /// RGI75CATTY.
        /// </summary>
        public const string RGI75CATTY = "RGI75CATTY";

        /// <summary>
        /// RGI75CATVL.
        /// </summary>
        public const string RGI75CATVL = "RGI75CATVL";

        /// <summary>
        /// RGI75CATDS.
        /// </summary>
        public const string RGI75CATDS = "RGI75CATDS";

        /// <summary>
        /// RGI75CATCO.
        /// </summary>
        public const string RGI75CATCO = "RGI75CATCO";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGUPMT.
        /// </summary>
        public const string RGUPMT = "RGUPMT";

        /// <summary>
        /// RGYFUTDT.
        /// </summary>
        public const string RGYFUTDT = "RGYFUTDT";

        /// <summary>
        /// RGFFU4.
        /// </summary>
        public const string RGFFU4 = "RGFFU4";

        /// <summary>
        /// RGFUT3.
        /// </summary>
        public const string RGFUT3 = "RGFUT3";

        /// <summary>
        /// RGX2.
        /// </summary>
        public const string RGX2 = "RGX2";

        /// <summary>
        /// RGFUTCH1.
        /// </summary>
        public const string RGFUTCH1 = "RGFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I869";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGPRNB", "RGPRNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RGLNMB", "RGLNMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RGEFTJ", "RGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RGI75CGSTR", "RGI75CGSTR", JdeDataType.Numeric),
        new JdeField("RGI75SGSTR", "RGI75SGSTR", JdeDataType.Numeric),
        new JdeField("RGI75IGSTR", "RGI75IGSTR", JdeDataType.Numeric),
        new JdeField("RGI75CESSR", "RGI75CESSR", JdeDataType.Numeric),
        new JdeField("RGI75CATTY", "RGI75CATTY", JdeDataType.String, 6),
        new JdeField("RGI75CATVL", "RGI75CATVL", JdeDataType.String, 40),
        new JdeField("RGI75CATDS", "RGI75CATDS", JdeDataType.String, 60),
        new JdeField("RGI75CATCO", "RGI75CATCO", JdeDataType.Numeric),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGUPMT", "RGUPMT", JdeDataType.Numeric),
        new JdeField("RGYFUTDT", "RGYFUTDT", JdeDataType.Numeric),
        new JdeField("RGFFU4", "RGFFU4", JdeDataType.Numeric),
        new JdeField("RGFUT3", "RGFUT3", JdeDataType.String, 60),
        new JdeField("RGX2", "RGX2", JdeDataType.String, 2),
        new JdeField("RGFUTCH1", "RGFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I869_0", "Primary Key on RGPRNB, RGLNMB, RGEFTJ", new[] { "RGPRNB", "RGLNMB", "RGEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
