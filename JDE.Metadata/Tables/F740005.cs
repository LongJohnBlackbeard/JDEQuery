using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740005 - .
/// </summary>
public class F740005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAKCO.
        /// </summary>
        public const string AAKCO = "AAKCO";

        /// <summary>
        /// AADCT.
        /// </summary>
        public const string AADCT = "AADCT";

        /// <summary>
        /// AADOC.
        /// </summary>
        public const string AADOC = "AADOC";

        /// <summary>
        /// AASFX.
        /// </summary>
        public const string AASFX = "AASFX";

        /// <summary>
        /// AAK74CONID.
        /// </summary>
        public const string AAK74CONID = "AAK74CONID";

        /// <summary>
        /// AAK74PROID.
        /// </summary>
        public const string AAK74PROID = "AAK74PROID";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAYFUTDT.
        /// </summary>
        public const string AAYFUTDT = "AAYFUTDT";

        /// <summary>
        /// AAFUT3.
        /// </summary>
        public const string AAFUT3 = "AAFUT3";

        /// <summary>
        /// AAFUTCH1.
        /// </summary>
        public const string AAFUTCH1 = "AAFUTCH1";

        /// <summary>
        /// AAX2.
        /// </summary>
        public const string AAX2 = "AAX2";

        /// <summary>
        /// AAFFU4.
        /// </summary>
        public const string AAFFU4 = "AAFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F740005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAKCO", "AAKCO", JdeDataType.String, 10, true, true),
        new JdeField("AADCT", "AADCT", JdeDataType.String, 4, true, true),
        new JdeField("AADOC", "AADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AASFX", "AASFX", JdeDataType.String, 6, true, true),
        new JdeField("AAK74CONID", "AAK74CONID", JdeDataType.String, 80),
        new JdeField("AAK74PROID", "AAK74PROID", JdeDataType.String, 80),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAYFUTDT", "AAYFUTDT", JdeDataType.Numeric),
        new JdeField("AAFUT3", "AAFUT3", JdeDataType.String, 60),
        new JdeField("AAFUTCH1", "AAFUTCH1", JdeDataType.String, 2),
        new JdeField("AAX2", "AAX2", JdeDataType.String, 2),
        new JdeField("AAFFU4", "AAFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740005_0", "Primary Key on AAKCO, AADCT, AADOC, AASFX", new[] { "AAKCO", "AADCT", "AADOC", "AASFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F740005_2", "Index on AAKCO, AADCT, AADOC", new[] { "AAKCO", "AADCT", "AADOC" })
    };
}
