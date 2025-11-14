using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L005 - .
/// </summary>
public class FF30L005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMSTSKID.
        /// </summary>
        public const string TMSTSKID = "TMSTSKID";

        /// <summary>
        /// TMSTSKPRP.
        /// </summary>
        public const string TMSTSKPRP = "TMSTSKPRP";

        /// <summary>
        /// TMTSKNAME.
        /// </summary>
        public const string TMTSKNAME = "TMTSKNAME";

        /// <summary>
        /// TMFSCID.
        /// </summary>
        public const string TMFSCID = "TMFSCID";

        /// <summary>
        /// TMDESC.
        /// </summary>
        public const string TMDESC = "TMDESC";

        /// <summary>
        /// TMTSKDSC.
        /// </summary>
        public const string TMTSKDSC = "TMTSKDSC";

        /// <summary>
        /// TMWRKTY.
        /// </summary>
        public const string TMWRKTY = "TMWRKTY";

        /// <summary>
        /// TMVALADD.
        /// </summary>
        public const string TMVALADD = "TMVALADD";

        /// <summary>
        /// TMDFRID.
        /// </summary>
        public const string TMDFRID = "TMDFRID";

        /// <summary>
        /// TMSTQTY.
        /// </summary>
        public const string TMSTQTY = "TMSTQTY";

        /// <summary>
        /// TMSTSKTIME.
        /// </summary>
        public const string TMSTSKTIME = "TMSTSKTIME";

        /// <summary>
        /// TMTIMEUOM.
        /// </summary>
        public const string TMTIMEUOM = "TMTIMEUOM";

        /// <summary>
        /// TMTQCDESC.
        /// </summary>
        public const string TMTQCDESC = "TMTQCDESC";

        /// <summary>
        /// TMTQCCRT.
        /// </summary>
        public const string TMTQCCRT = "TMTQCCRT";

        /// <summary>
        /// TMURCD.
        /// </summary>
        public const string TMURCD = "TMURCD";

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
        /// TMTORG.
        /// </summary>
        public const string TMTORG = "TMTORG";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMMKEY.
        /// </summary>
        public const string TMMKEY = "TMMKEY";

        /// <summary>
        /// TMUUPMJ.
        /// </summary>
        public const string TMUUPMJ = "TMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMSTSKID", "TMSTSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TMSTSKPRP", "TMSTSKPRP", JdeDataType.String, 4),
        new JdeField("TMTSKNAME", "TMTSKNAME", JdeDataType.String, 60),
        new JdeField("TMFSCID", "TMFSCID", JdeDataType.Numeric),
        new JdeField("TMDESC", "TMDESC", JdeDataType.String, 60),
        new JdeField("TMTSKDSC", "TMTSKDSC", JdeDataType.String, 510),
        new JdeField("TMWRKTY", "TMWRKTY", JdeDataType.String, 4),
        new JdeField("TMVALADD", "TMVALADD", JdeDataType.String, 4),
        new JdeField("TMDFRID", "TMDFRID", JdeDataType.Numeric),
        new JdeField("TMSTQTY", "TMSTQTY", JdeDataType.Numeric),
        new JdeField("TMSTSKTIME", "TMSTSKTIME", JdeDataType.Numeric),
        new JdeField("TMTIMEUOM", "TMTIMEUOM", JdeDataType.String, 2),
        new JdeField("TMTQCDESC", "TMTQCDESC", JdeDataType.String, 510),
        new JdeField("TMTQCCRT", "TMTQCCRT", JdeDataType.String, 4),
        new JdeField("TMURCD", "TMURCD", JdeDataType.String, 4),
        new JdeField("TMURDT", "TMURDT", JdeDataType.Numeric),
        new JdeField("TMURAT", "TMURAT", JdeDataType.Numeric),
        new JdeField("TMURAB", "TMURAB", JdeDataType.Numeric),
        new JdeField("TMURRF", "TMURRF", JdeDataType.String, 30),
        new JdeField("TMTORG", "TMTORG", JdeDataType.String, 20),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMMKEY", "TMMKEY", JdeDataType.String, 30),
        new JdeField("TMUUPMJ", "TMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L005_0", "Primary Key on TMSTSKID", new[] { "TMSTSKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L005_2", "Index on TMTSKNAME, TMFSCID", new[] { "TMTSKNAME", "TMFSCID" }),
        new JdeIndex("FF30L005_3", "Index on TMFSCID", new[] { "TMFSCID" })
    };
}
