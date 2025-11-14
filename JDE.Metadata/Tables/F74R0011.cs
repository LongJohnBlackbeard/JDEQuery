using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0011 - .
/// </summary>
public class F74R0011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICICUT.
        /// </summary>
        public const string ICICUT = "ICICUT";

        /// <summary>
        /// ICICU.
        /// </summary>
        public const string ICICU = "ICICU";

        /// <summary>
        /// ICR74CSTA.
        /// </summary>
        public const string ICR74CSTA = "ICR74CSTA";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICICUT", "ICICUT", JdeDataType.String, 4, true, true),
        new JdeField("ICICU", "ICICU", JdeDataType.Numeric, null, true, true),
        new JdeField("ICR74CSTA", "ICR74CSTA", JdeDataType.String, 4),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0011_0", "Primary Key on ICICUT, ICICU", new[] { "ICICUT", "ICICU" }, isUnique: true, isPrimaryKey: true)
    };
}
