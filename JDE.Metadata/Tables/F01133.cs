using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01133 - .
/// </summary>
public class F01133 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZTSERK.
        /// </summary>
        public const string ZTSERK = "ZTSERK";

        /// <summary>
        /// ZTAN8.
        /// </summary>
        public const string ZTAN8 = "ZTAN8";

        /// <summary>
        /// ZTALPH.
        /// </summary>
        public const string ZTALPH = "ZTALPH";

        /// <summary>
        /// ZTMBDS.
        /// </summary>
        public const string ZTMBDS = "ZTMBDS";

        /// <summary>
        /// ZTDTI.
        /// </summary>
        public const string ZTDTI = "ZTDTI";

        /// <summary>
        /// ZTCMDF.
        /// </summary>
        public const string ZTCMDF = "ZTCMDF";

        /// <summary>
        /// ZTSTSM.
        /// </summary>
        public const string ZTSTSM = "ZTSTSM";

        /// <summary>
        /// ZTDSS5.
        /// </summary>
        public const string ZTDSS5 = "ZTDSS5";

        /// <summary>
        /// ZTMSGA.
        /// </summary>
        public const string ZTMSGA = "ZTMSGA";

        /// <summary>
        /// ZTAB3.
        /// </summary>
        public const string ZTAB3 = "ZTAB3";

        /// <summary>
        /// ZTUPMT.
        /// </summary>
        public const string ZTUPMT = "ZTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F01133";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZTSERK", "ZTSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTAN8", "ZTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTALPH", "ZTALPH", JdeDataType.String, 80),
        new JdeField("ZTMBDS", "ZTMBDS", JdeDataType.String, 4),
        new JdeField("ZTDTI", "ZTDTI", JdeDataType.Numeric),
        new JdeField("ZTCMDF", "ZTCMDF", JdeDataType.String, 2),
        new JdeField("ZTSTSM", "ZTSTSM", JdeDataType.String, 2),
        new JdeField("ZTDSS5", "ZTDSS5", JdeDataType.Numeric),
        new JdeField("ZTMSGA", "ZTMSGA", JdeDataType.String, 2),
        new JdeField("ZTAB3", "ZTAB3", JdeDataType.String, 2),
        new JdeField("ZTUPMT", "ZTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01133_0", "Primary Key on ZTSERK, ZTAN8", new[] { "ZTSERK", "ZTAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01133_2", "Index on ZTAN8, ZTMBDS, ZTSTSM", new[] { "ZTAN8", "ZTMBDS", "ZTSTSM" }),
        new JdeIndex("F01133_3", "Index on ZTAN8, ZTMBDS, SYS_NC00012$, SYS_NC00013$, ZTSTSM", new[] { "ZTAN8", "ZTMBDS", "SYS_NC00012$", "SYS_NC00013$", "ZTSTSM" })
    };
}
