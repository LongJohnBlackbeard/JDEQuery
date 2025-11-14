using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B1020 - .
/// </summary>
public class F76B1020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APBNNF.
        /// </summary>
        public const string APBNNF = "APBNNF";

        /// <summary>
        /// APBSER.
        /// </summary>
        public const string APBSER = "APBSER";

        /// <summary>
        /// APN001.
        /// </summary>
        public const string APN001 = "APN001";

        /// <summary>
        /// APDCT.
        /// </summary>
        public const string APDCT = "APDCT";

        /// <summary>
        /// APB76AUPER.
        /// </summary>
        public const string APB76AUPER = "APB76AUPER";

        /// <summary>
        /// APB76APERS.
        /// </summary>
        public const string APB76APERS = "APB76APERS";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B1020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APBNNF", "APBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("APBSER", "APBSER", JdeDataType.String, 4, true, true),
        new JdeField("APN001", "APN001", JdeDataType.Numeric, null, true, true),
        new JdeField("APDCT", "APDCT", JdeDataType.String, 4, true, true),
        new JdeField("APB76AUPER", "APB76AUPER", JdeDataType.Numeric, null, true, true),
        new JdeField("APB76APERS", "APB76APERS", JdeDataType.Numeric, null, true, true),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B1020_0", "Primary Key on APBNNF, APBSER, APN001, APDCT, APB76APERS, APB76AUPER", new[] { "APBNNF", "APBSER", "APN001", "APDCT", "APB76APERS", "APB76AUPER" }, isUnique: true, isPrimaryKey: true)
    };
}
