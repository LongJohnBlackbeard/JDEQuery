using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B400G - .
/// </summary>
public class F76B400G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISUKID.
        /// </summary>
        public const string ISUKID = "ISUKID";

        /// <summary>
        /// ISDGJ.
        /// </summary>
        public const string ISDGJ = "ISDGJ";

        /// <summary>
        /// ISLITM.
        /// </summary>
        public const string ISLITM = "ISLITM";

        /// <summary>
        /// ISDSC1.
        /// </summary>
        public const string ISDSC1 = "ISDSC1";

        /// <summary>
        /// ISRDOR.
        /// </summary>
        public const string ISRDOR = "ISRDOR";

        /// <summary>
        /// ISC1FU.
        /// </summary>
        public const string ISC1FU = "ISC1FU";

        /// <summary>
        /// ISC2FU.
        /// </summary>
        public const string ISC2FU = "ISC2FU";

        /// <summary>
        /// ISD1FU.
        /// </summary>
        public const string ISD1FU = "ISD1FU";

        /// <summary>
        /// ISD2FU.
        /// </summary>
        public const string ISD2FU = "ISD2FU";

        /// <summary>
        /// ISN1FU.
        /// </summary>
        public const string ISN1FU = "ISN1FU";

        /// <summary>
        /// ISN2FU.
        /// </summary>
        public const string ISN2FU = "ISN2FU";

        /// <summary>
        /// ISN3FU.
        /// </summary>
        public const string ISN3FU = "ISN3FU";

        /// <summary>
        /// ISN4FU.
        /// </summary>
        public const string ISN4FU = "ISN4FU";

        /// <summary>
        /// ISN5FU.
        /// </summary>
        public const string ISN5FU = "ISN5FU";

        /// <summary>
        /// ISN6FU.
        /// </summary>
        public const string ISN6FU = "ISN6FU";

        /// <summary>
        /// ISN7FU.
        /// </summary>
        public const string ISN7FU = "ISN7FU";

        /// <summary>
        /// ISS1FU.
        /// </summary>
        public const string ISS1FU = "ISS1FU";

        /// <summary>
        /// ISS2FU.
        /// </summary>
        public const string ISS2FU = "ISS2FU";

        /// <summary>
        /// ISS3FU.
        /// </summary>
        public const string ISS3FU = "ISS3FU";

        /// <summary>
        /// ISS4FU.
        /// </summary>
        public const string ISS4FU = "ISS4FU";

        /// <summary>
        /// ISGENLNG.
        /// </summary>
        public const string ISGENLNG = "ISGENLNG";

        /// <summary>
        /// ISTORG.
        /// </summary>
        public const string ISTORG = "ISTORG";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B400G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISUKID", "ISUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDGJ", "ISDGJ", JdeDataType.Numeric),
        new JdeField("ISLITM", "ISLITM", JdeDataType.String, 50),
        new JdeField("ISDSC1", "ISDSC1", JdeDataType.String, 60),
        new JdeField("ISRDOR", "ISRDOR", JdeDataType.String, 2),
        new JdeField("ISC1FU", "ISC1FU", JdeDataType.String, 2),
        new JdeField("ISC2FU", "ISC2FU", JdeDataType.String, 2),
        new JdeField("ISD1FU", "ISD1FU", JdeDataType.Numeric),
        new JdeField("ISD2FU", "ISD2FU", JdeDataType.Numeric),
        new JdeField("ISN1FU", "ISN1FU", JdeDataType.Numeric),
        new JdeField("ISN2FU", "ISN2FU", JdeDataType.Numeric),
        new JdeField("ISN3FU", "ISN3FU", JdeDataType.Numeric),
        new JdeField("ISN4FU", "ISN4FU", JdeDataType.Numeric),
        new JdeField("ISN5FU", "ISN5FU", JdeDataType.Numeric),
        new JdeField("ISN6FU", "ISN6FU", JdeDataType.Numeric),
        new JdeField("ISN7FU", "ISN7FU", JdeDataType.Numeric),
        new JdeField("ISS1FU", "ISS1FU", JdeDataType.String, 60),
        new JdeField("ISS2FU", "ISS2FU", JdeDataType.String, 60),
        new JdeField("ISS3FU", "ISS3FU", JdeDataType.String, 6),
        new JdeField("ISS4FU", "ISS4FU", JdeDataType.String, 6),
        new JdeField("ISGENLNG", "ISGENLNG", JdeDataType.Numeric),
        new JdeField("ISTORG", "ISTORG", JdeDataType.String, 20),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B400G_0", "Primary Key on ISUKID", new[] { "ISUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B400G_2", "Unique Index on ISLITM", new[] { "ISLITM" }, isUnique: true)
    };
}
