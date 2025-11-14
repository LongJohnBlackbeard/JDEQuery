using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740004 - .
/// </summary>
public class F740004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAKCOO.
        /// </summary>
        public const string SAKCOO = "SAKCOO";

        /// <summary>
        /// SADCTO.
        /// </summary>
        public const string SADCTO = "SADCTO";

        /// <summary>
        /// SADOCO.
        /// </summary>
        public const string SADOCO = "SADOCO";

        /// <summary>
        /// SALNID.
        /// </summary>
        public const string SALNID = "SALNID";

        /// <summary>
        /// SAK74CONID.
        /// </summary>
        public const string SAK74CONID = "SAK74CONID";

        /// <summary>
        /// SAK74PROID.
        /// </summary>
        public const string SAK74PROID = "SAK74PROID";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";

        /// <summary>
        /// SAYFUTDT.
        /// </summary>
        public const string SAYFUTDT = "SAYFUTDT";

        /// <summary>
        /// SAFUT3.
        /// </summary>
        public const string SAFUT3 = "SAFUT3";

        /// <summary>
        /// SAFUTCH1.
        /// </summary>
        public const string SAFUTCH1 = "SAFUTCH1";

        /// <summary>
        /// SAX2.
        /// </summary>
        public const string SAX2 = "SAX2";

        /// <summary>
        /// SAFFU4.
        /// </summary>
        public const string SAFFU4 = "SAFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F740004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAKCOO", "SAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SADCTO", "SADCTO", JdeDataType.String, 4, true, true),
        new JdeField("SADOCO", "SADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SALNID", "SALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SAK74CONID", "SAK74CONID", JdeDataType.String, 80),
        new JdeField("SAK74PROID", "SAK74PROID", JdeDataType.String, 80),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric),
        new JdeField("SAYFUTDT", "SAYFUTDT", JdeDataType.Numeric),
        new JdeField("SAFUT3", "SAFUT3", JdeDataType.String, 60),
        new JdeField("SAFUTCH1", "SAFUTCH1", JdeDataType.String, 2),
        new JdeField("SAX2", "SAX2", JdeDataType.String, 2),
        new JdeField("SAFFU4", "SAFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740004_0", "Primary Key on SAKCOO, SADCTO, SADOCO, SALNID", new[] { "SAKCOO", "SADCTO", "SADOCO", "SALNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F740004_2", "Index on SAKCOO, SADCTO, SADOCO", new[] { "SAKCOO", "SADCTO", "SADOCO" })
    };
}
