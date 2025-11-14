using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T008 - .
/// </summary>
public class F75T008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMTXA1.
        /// </summary>
        public const string TMTXA1 = "TMTXA1";

        /// <summary>
        /// TMEXR1.
        /// </summary>
        public const string TMEXR1 = "TMEXR1";

        /// <summary>
        /// TM75TTXT.
        /// </summary>
        public const string TM75TTXT = "TM75TTXT";

        /// <summary>
        /// TMDL01.
        /// </summary>
        public const string TMDL01 = "TMDL01";

        /// <summary>
        /// TMURC1.
        /// </summary>
        public const string TMURC1 = "TMURC1";

        /// <summary>
        /// TMURDT.
        /// </summary>
        public const string TMURDT = "TMURDT";

        /// <summary>
        /// TMURAT.
        /// </summary>
        public const string TMURAT = "TMURAT";

        /// <summary>
        /// TMURAB.
        /// </summary>
        public const string TMURAB = "TMURAB";

        /// <summary>
        /// TMURRF.
        /// </summary>
        public const string TMURRF = "TMURRF";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMJOBN.
        /// </summary>
        public const string TMJOBN = "TMJOBN";

        /// <summary>
        /// TMUPMJ.
        /// </summary>
        public const string TMUPMJ = "TMUPMJ";

        /// <summary>
        /// TMTDAY.
        /// </summary>
        public const string TMTDAY = "TMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMTXA1", "TMTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TMEXR1", "TMEXR1", JdeDataType.String, 4, true, true),
        new JdeField("TM75TTXT", "TM75TTXT", JdeDataType.String, 2),
        new JdeField("TMDL01", "TMDL01", JdeDataType.String, 60),
        new JdeField("TMURC1", "TMURC1", JdeDataType.String, 6),
        new JdeField("TMURDT", "TMURDT", JdeDataType.Numeric),
        new JdeField("TMURAT", "TMURAT", JdeDataType.Numeric),
        new JdeField("TMURAB", "TMURAB", JdeDataType.Numeric),
        new JdeField("TMURRF", "TMURRF", JdeDataType.String, 30),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMTDAY", "TMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T008_0", "Primary Key on TMTXA1, TMEXR1", new[] { "TMTXA1", "TMEXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
