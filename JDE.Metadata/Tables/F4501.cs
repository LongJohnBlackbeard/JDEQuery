using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4501 - .
/// </summary>
public class F4501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSMASN.
        /// </summary>
        public const string MSMASN = "MSMASN";

        /// <summary>
        /// MSPRIG.
        /// </summary>
        public const string MSPRIG = "MSPRIG";

        /// <summary>
        /// MSMSQN.
        /// </summary>
        public const string MSMSQN = "MSMSQN";

        /// <summary>
        /// MSASN.
        /// </summary>
        public const string MSASN = "MSASN";

        /// <summary>
        /// MSEFTJ.
        /// </summary>
        public const string MSEFTJ = "MSEFTJ";

        /// <summary>
        /// MSEXDJ.
        /// </summary>
        public const string MSEXDJ = "MSEXDJ";

        /// <summary>
        /// MSMSFL.
        /// </summary>
        public const string MSMSFL = "MSMSFL";

        /// <summary>
        /// MSSKTS.
        /// </summary>
        public const string MSSKTS = "MSSKTS";

        /// <summary>
        /// MSMACC.
        /// </summary>
        public const string MSMACC = "MSMACC";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MSTDAY.
        /// </summary>
        public const string MSTDAY = "MSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSMASN", "MSMASN", JdeDataType.String, 16, true, true),
        new JdeField("MSPRIG", "MSPRIG", JdeDataType.Numeric),
        new JdeField("MSMSQN", "MSMSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("MSASN", "MSASN", JdeDataType.String, 16, true, true),
        new JdeField("MSEFTJ", "MSEFTJ", JdeDataType.Numeric),
        new JdeField("MSEXDJ", "MSEXDJ", JdeDataType.Numeric),
        new JdeField("MSMSFL", "MSMSFL", JdeDataType.String, 2),
        new JdeField("MSSKTS", "MSSKTS", JdeDataType.Numeric),
        new JdeField("MSMACC", "MSMACC", JdeDataType.String, 2),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MSTDAY", "MSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4501_0", "Primary Key on MSMASN, MSMSQN, MSASN", new[] { "MSMASN", "MSMSQN", "MSASN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4501_2", "Index on MSMASN, MSASN", new[] { "MSMASN", "MSASN" })
    };
}
