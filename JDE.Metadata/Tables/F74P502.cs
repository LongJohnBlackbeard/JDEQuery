using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P502 - .
/// </summary>
public class F74P502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AITXA1.
        /// </summary>
        public const string AITXA1 = "AITXA1";

        /// <summary>
        /// AIITM.
        /// </summary>
        public const string AIITM = "AIITM";

        /// <summary>
        /// AIEFDJ.
        /// </summary>
        public const string AIEFDJ = "AIEFDJ";

        /// <summary>
        /// AIP74TXRC.
        /// </summary>
        public const string AIP74TXRC = "AIP74TXRC";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";

        /// <summary>
        /// AIDATF01.
        /// </summary>
        public const string AIDATF01 = "AIDATF01";

        /// <summary>
        /// AIDEPFUT2.
        /// </summary>
        public const string AIDEPFUT2 = "AIDEPFUT2";

        /// <summary>
        /// AIACTFU1.
        /// </summary>
        public const string AIACTFU1 = "AIACTFU1";

        /// <summary>
        /// AIFLAG.
        /// </summary>
        public const string AIFLAG = "AIFLAG";

        /// <summary>
        /// AIP74CGCO.
        /// </summary>
        public const string AIP74CGCO = "AIP74CGCO";
    }

    /// <inheritdoc />
    public override string TableName => "F74P502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AITXA1", "AITXA1", JdeDataType.String, 20, true, true),
        new JdeField("AIITM", "AIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("AIEFDJ", "AIEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AIP74TXRC", "AIP74TXRC", JdeDataType.String, 4),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric),
        new JdeField("AIDATF01", "AIDATF01", JdeDataType.Numeric),
        new JdeField("AIDEPFUT2", "AIDEPFUT2", JdeDataType.String, 60),
        new JdeField("AIACTFU1", "AIACTFU1", JdeDataType.String, 2),
        new JdeField("AIFLAG", "AIFLAG", JdeDataType.String, 2),
        new JdeField("AIP74CGCO", "AIP74CGCO", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P502_0", "Primary Key on AITXA1, AIITM, AIEFDJ", new[] { "AITXA1", "AIITM", "AIEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
