using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4720 - .
/// </summary>
public class F4720 : JdeTable
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
        /// TMTIMEZONES.
        /// </summary>
        public const string TMTIMEZONES = "TMTIMEZONES";

        /// <summary>
        /// TMDSAVNAME.
        /// </summary>
        public const string TMDSAVNAME = "TMDSAVNAME";

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

        /// <summary>
        /// TMGAN8.
        /// </summary>
        public const string TMGAN8 = "TMGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F4720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMAN8", "TMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TMTIMEZONES", "TMTIMEZONES", JdeDataType.String, 4),
        new JdeField("TMDSAVNAME", "TMDSAVNAME", JdeDataType.String, 20),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMTDAY", "TMTDAY", JdeDataType.Numeric),
        new JdeField("TMGAN8", "TMGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4720_0", "Primary Key on TMAN8", new[] { "TMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
