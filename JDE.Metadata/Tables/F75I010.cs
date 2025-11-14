using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I010 - .
/// </summary>
public class F75I010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABYPN1.
        /// </summary>
        public const string ABYPN1 = "ABYPN1";

        /// <summary>
        /// ABYTN1.
        /// </summary>
        public const string ABYTN1 = "ABYTN1";

        /// <summary>
        /// ABYTYP.
        /// </summary>
        public const string ABYTYP = "ABYTYP";

        /// <summary>
        /// ABI75WCTY.
        /// </summary>
        public const string ABI75WCTY = "ABI75WCTY";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABYPN1", "ABYPN1", JdeDataType.String, 80),
        new JdeField("ABYTN1", "ABYTN1", JdeDataType.String, 80),
        new JdeField("ABYTYP", "ABYTYP", JdeDataType.String, 2),
        new JdeField("ABI75WCTY", "ABI75WCTY", JdeDataType.String, 2),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I010_0", "Primary Key on ABAN8", new[] { "ABAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
