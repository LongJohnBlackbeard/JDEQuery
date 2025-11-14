using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E105 - .
/// </summary>
public class F09E105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMEXPTYPE.
        /// </summary>
        public const string TMEXPTYPE = "TMEXPTYPE";

        /// <summary>
        /// TMLOCATN.
        /// </summary>
        public const string TMLOCATN = "TMLOCATN";

        /// <summary>
        /// TMCTR.
        /// </summary>
        public const string TMCTR = "TMCTR";

        /// <summary>
        /// TMBILLBLE.
        /// </summary>
        public const string TMBILLBLE = "TMBILLBLE";

        /// <summary>
        /// TMTXA1.
        /// </summary>
        public const string TMTXA1 = "TMTXA1";

        /// <summary>
        /// TMEXR1.
        /// </summary>
        public const string TMEXR1 = "TMEXR1";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMJOBN.
        /// </summary>
        public const string TMJOBN = "TMJOBN";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMUPMJ.
        /// </summary>
        public const string TMUPMJ = "TMUPMJ";

        /// <summary>
        /// TMUPMT.
        /// </summary>
        public const string TMUPMT = "TMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09E105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMEXPTYPE", "TMEXPTYPE", JdeDataType.String, 8, true, true),
        new JdeField("TMLOCATN", "TMLOCATN", JdeDataType.String, 20, true, true),
        new JdeField("TMCTR", "TMCTR", JdeDataType.String, 6, true, true),
        new JdeField("TMBILLBLE", "TMBILLBLE", JdeDataType.String, 2, true, true),
        new JdeField("TMTXA1", "TMTXA1", JdeDataType.String, 20),
        new JdeField("TMEXR1", "TMEXR1", JdeDataType.String, 4),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMUPMT", "TMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E105_0", "Primary Key on TMEXPTYPE, TMCTR, TMLOCATN, TMBILLBLE", new[] { "TMEXPTYPE", "TMCTR", "TMLOCATN", "TMBILLBLE" }, isUnique: true, isPrimaryKey: true)
    };
}
