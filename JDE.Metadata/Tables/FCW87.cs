using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW87 - .
/// </summary>
public class FCW87 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LGJOBS.
        /// </summary>
        public const string LGJOBS = "LGJOBS";

        /// <summary>
        /// LGC9LVL0.
        /// </summary>
        public const string LGC9LVL0 = "LGC9LVL0";

        /// <summary>
        /// LGMCU.
        /// </summary>
        public const string LGMCU = "LGMCU";

        /// <summary>
        /// LGITM.
        /// </summary>
        public const string LGITM = "LGITM";

        /// <summary>
        /// LGLITM.
        /// </summary>
        public const string LGLITM = "LGLITM";

        /// <summary>
        /// LGPSF1.
        /// </summary>
        public const string LGPSF1 = "LGPSF1";

        /// <summary>
        /// LGPSF2.
        /// </summary>
        public const string LGPSF2 = "LGPSF2";

        /// <summary>
        /// LGPSF3.
        /// </summary>
        public const string LGPSF3 = "LGPSF3";

        /// <summary>
        /// LGPSF4.
        /// </summary>
        public const string LGPSF4 = "LGPSF4";

        /// <summary>
        /// LGPSF5.
        /// </summary>
        public const string LGPSF5 = "LGPSF5";

        /// <summary>
        /// LGPSF6.
        /// </summary>
        public const string LGPSF6 = "LGPSF6";
    }

    /// <inheritdoc />
    public override string TableName => "FCW87";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LGJOBS", "LGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LGC9LVL0", "LGC9LVL0", JdeDataType.String, 50, true, true),
        new JdeField("LGMCU", "LGMCU", JdeDataType.String, 24, true, true),
        new JdeField("LGITM", "LGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LGLITM", "LGLITM", JdeDataType.String, 50),
        new JdeField("LGPSF1", "LGPSF1", JdeDataType.String, 2),
        new JdeField("LGPSF2", "LGPSF2", JdeDataType.String, 2),
        new JdeField("LGPSF3", "LGPSF3", JdeDataType.String, 2),
        new JdeField("LGPSF4", "LGPSF4", JdeDataType.String, 2),
        new JdeField("LGPSF5", "LGPSF5", JdeDataType.String, 2),
        new JdeField("LGPSF6", "LGPSF6", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW87_0", "Primary Key on LGJOBS, LGC9LVL0, LGMCU, LGITM", new[] { "LGJOBS", "LGC9LVL0", "LGMCU", "LGITM" }, isUnique: true, isPrimaryKey: true)
    };
}
