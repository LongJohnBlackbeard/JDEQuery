using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I603 - .
/// </summary>
public class F75I603 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMAN8.
        /// </summary>
        public const string TMAN8 = "TMAN8";

        /// <summary>
        /// TMI75TXTY.
        /// </summary>
        public const string TMI75TXTY = "TMI75TXTY";

        /// <summary>
        /// TMCO.
        /// </summary>
        public const string TMCO = "TMCO";

        /// <summary>
        /// TMMCU.
        /// </summary>
        public const string TMMCU = "TMMCU";

        /// <summary>
        /// TMAREC.
        /// </summary>
        public const string TMAREC = "TMAREC";

        /// <summary>
        /// TMAPD.
        /// </summary>
        public const string TMAPD = "TMAPD";

        /// <summary>
        /// TMTOTO.
        /// </summary>
        public const string TMTOTO = "TMTOTO";

        /// <summary>
        /// TMAA1.
        /// </summary>
        public const string TMAA1 = "TMAA1";

        /// <summary>
        /// TMI75ICC.
        /// </summary>
        public const string TMI75ICC = "TMI75ICC";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMUPMJ.
        /// </summary>
        public const string TMUPMJ = "TMUPMJ";

        /// <summary>
        /// TMUPMT.
        /// </summary>
        public const string TMUPMT = "TMUPMT";

        /// <summary>
        /// TMJOBN.
        /// </summary>
        public const string TMJOBN = "TMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I603";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMAN8", "TMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TMI75TXTY", "TMI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("TMCO", "TMCO", JdeDataType.String, 10, true, true),
        new JdeField("TMMCU", "TMMCU", JdeDataType.String, 24, true, true),
        new JdeField("TMAREC", "TMAREC", JdeDataType.Numeric),
        new JdeField("TMAPD", "TMAPD", JdeDataType.Numeric),
        new JdeField("TMTOTO", "TMTOTO", JdeDataType.Numeric),
        new JdeField("TMAA1", "TMAA1", JdeDataType.Numeric),
        new JdeField("TMI75ICC", "TMI75ICC", JdeDataType.String, 2, true, true),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMUPMT", "TMUPMT", JdeDataType.Numeric),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I603_0", "Primary Key on TMAN8, TMCO, TMMCU, TMI75ICC, TMI75TXTY", new[] { "TMAN8", "TMCO", "TMMCU", "TMI75ICC", "TMI75TXTY" }, isUnique: true, isPrimaryKey: true)
    };
}
