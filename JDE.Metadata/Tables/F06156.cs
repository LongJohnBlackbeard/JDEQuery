using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06156 - .
/// </summary>
public class F06156 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YUAN8.
        /// </summary>
        public const string YUAN8 = "YUAN8";

        /// <summary>
        /// YUDOCM.
        /// </summary>
        public const string YUDOCM = "YUDOCM";

        /// <summary>
        /// YUCKD.
        /// </summary>
        public const string YUCKD = "YUCKD";

        /// <summary>
        /// YUCKCN.
        /// </summary>
        public const string YUCKCN = "YUCKCN";

        /// <summary>
        /// YUPPNB.
        /// </summary>
        public const string YUPPNB = "YUPPNB";

        /// <summary>
        /// YUPPED.
        /// </summary>
        public const string YUPPED = "YUPPED";

        /// <summary>
        /// YUHMO.
        /// </summary>
        public const string YUHMO = "YUHMO";

        /// <summary>
        /// YUICC.
        /// </summary>
        public const string YUICC = "YUICC";

        /// <summary>
        /// YUICS.
        /// </summary>
        public const string YUICS = "YUICS";

        /// <summary>
        /// YUHRW.
        /// </summary>
        public const string YUHRW = "YUHRW";

        /// <summary>
        /// YUUNPC.
        /// </summary>
        public const string YUUNPC = "YUUNPC";

        /// <summary>
        /// YUUM.
        /// </summary>
        public const string YUUM = "YUUM";

        /// <summary>
        /// YUGPAY.
        /// </summary>
        public const string YUGPAY = "YUGPAY";

        /// <summary>
        /// YUNPAY.
        /// </summary>
        public const string YUNPAY = "YUNPAY";

        /// <summary>
        /// YUGDED.
        /// </summary>
        public const string YUGDED = "YUGDED";

        /// <summary>
        /// YUGBEN.
        /// </summary>
        public const string YUGBEN = "YUGBEN";

        /// <summary>
        /// YUGTXW.
        /// </summary>
        public const string YUGTXW = "YUGTXW";

        /// <summary>
        /// YUICU.
        /// </summary>
        public const string YUICU = "YUICU";

        /// <summary>
        /// YUDICJ.
        /// </summary>
        public const string YUDICJ = "YUDICJ";

        /// <summary>
        /// YURCND.
        /// </summary>
        public const string YURCND = "YURCND";

        /// <summary>
        /// YUGLBA.
        /// </summary>
        public const string YUGLBA = "YUGLBA";

        /// <summary>
        /// YUDOCS.
        /// </summary>
        public const string YUDOCS = "YUDOCS";

        /// <summary>
        /// YUDOCP.
        /// </summary>
        public const string YUDOCP = "YUDOCP";

        /// <summary>
        /// YUREDT.
        /// </summary>
        public const string YUREDT = "YUREDT";

        /// <summary>
        /// YUCLDT.
        /// </summary>
        public const string YUCLDT = "YUCLDT";

        /// <summary>
        /// YUSCKC.
        /// </summary>
        public const string YUSCKC = "YUSCKC";

        /// <summary>
        /// YUHMCO.
        /// </summary>
        public const string YUHMCO = "YUHMCO";

        /// <summary>
        /// YUHMCU.
        /// </summary>
        public const string YUHMCU = "YUHMCU";

        /// <summary>
        /// YUMAIL.
        /// </summary>
        public const string YUMAIL = "YUMAIL";

        /// <summary>
        /// YUSG.
        /// </summary>
        public const string YUSG = "YUSG";

        /// <summary>
        /// YUTHTY.
        /// </summary>
        public const string YUTHTY = "YUTHTY";

        /// <summary>
        /// YUTAXX.
        /// </summary>
        public const string YUTAXX = "YUTAXX";

        /// <summary>
        /// YUWAN8.
        /// </summary>
        public const string YUWAN8 = "YUWAN8";

        /// <summary>
        /// YUCTRY.
        /// </summary>
        public const string YUCTRY = "YUCTRY";

        /// <summary>
        /// YUP001.
        /// </summary>
        public const string YUP001 = "YUP001";

        /// <summary>
        /// YUP002.
        /// </summary>
        public const string YUP002 = "YUP002";

        /// <summary>
        /// YUP003.
        /// </summary>
        public const string YUP003 = "YUP003";

        /// <summary>
        /// YUP004.
        /// </summary>
        public const string YUP004 = "YUP004";

        /// <summary>
        /// YUPID.
        /// </summary>
        public const string YUPID = "YUPID";

        /// <summary>
        /// YUUPMJ.
        /// </summary>
        public const string YUUPMJ = "YUUPMJ";

        /// <summary>
        /// YUDTSP.
        /// </summary>
        public const string YUDTSP = "YUDTSP";

        /// <summary>
        /// YUUSER.
        /// </summary>
        public const string YUUSER = "YUUSER";

        /// <summary>
        /// YURCKN.
        /// </summary>
        public const string YURCKN = "YURCKN";

        /// <summary>
        /// YUPRNS.
        /// </summary>
        public const string YUPRNS = "YUPRNS";

        /// <summary>
        /// YUAUBP.
        /// </summary>
        public const string YUAUBP = "YUAUBP";
    }

    /// <inheritdoc />
    public override string TableName => "F06156";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YUAN8", "YUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YUDOCM", "YUDOCM", JdeDataType.Numeric),
        new JdeField("YUCKD", "YUCKD", JdeDataType.Numeric),
        new JdeField("YUCKCN", "YUCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YUPPNB", "YUPPNB", JdeDataType.String, 6),
        new JdeField("YUPPED", "YUPPED", JdeDataType.Numeric),
        new JdeField("YUHMO", "YUHMO", JdeDataType.Numeric),
        new JdeField("YUICC", "YUICC", JdeDataType.String, 2, true, true),
        new JdeField("YUICS", "YUICS", JdeDataType.String, 2),
        new JdeField("YUHRW", "YUHRW", JdeDataType.Numeric),
        new JdeField("YUUNPC", "YUUNPC", JdeDataType.Numeric),
        new JdeField("YUUM", "YUUM", JdeDataType.String, 4),
        new JdeField("YUGPAY", "YUGPAY", JdeDataType.Numeric),
        new JdeField("YUNPAY", "YUNPAY", JdeDataType.Numeric),
        new JdeField("YUGDED", "YUGDED", JdeDataType.Numeric),
        new JdeField("YUGBEN", "YUGBEN", JdeDataType.Numeric),
        new JdeField("YUGTXW", "YUGTXW", JdeDataType.Numeric),
        new JdeField("YUICU", "YUICU", JdeDataType.Numeric),
        new JdeField("YUDICJ", "YUDICJ", JdeDataType.Numeric),
        new JdeField("YURCND", "YURCND", JdeDataType.String, 2),
        new JdeField("YUGLBA", "YUGLBA", JdeDataType.String, 16),
        new JdeField("YUDOCS", "YUDOCS", JdeDataType.Numeric),
        new JdeField("YUDOCP", "YUDOCP", JdeDataType.Numeric),
        new JdeField("YUREDT", "YUREDT", JdeDataType.Numeric),
        new JdeField("YUCLDT", "YUCLDT", JdeDataType.Numeric),
        new JdeField("YUSCKC", "YUSCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("YUHMCO", "YUHMCO", JdeDataType.String, 10),
        new JdeField("YUHMCU", "YUHMCU", JdeDataType.String, 24),
        new JdeField("YUMAIL", "YUMAIL", JdeDataType.String, 20),
        new JdeField("YUSG", "YUSG", JdeDataType.String, 24),
        new JdeField("YUTHTY", "YUTHTY", JdeDataType.String, 2),
        new JdeField("YUTAXX", "YUTAXX", JdeDataType.String, 40),
        new JdeField("YUWAN8", "YUWAN8", JdeDataType.Numeric),
        new JdeField("YUCTRY", "YUCTRY", JdeDataType.Numeric),
        new JdeField("YUP001", "YUP001", JdeDataType.String, 6),
        new JdeField("YUP002", "YUP002", JdeDataType.String, 6),
        new JdeField("YUP003", "YUP003", JdeDataType.String, 6),
        new JdeField("YUP004", "YUP004", JdeDataType.String, 6),
        new JdeField("YUPID", "YUPID", JdeDataType.String, 20),
        new JdeField("YUUPMJ", "YUUPMJ", JdeDataType.Numeric),
        new JdeField("YUDTSP", "YUDTSP", JdeDataType.Numeric),
        new JdeField("YUUSER", "YUUSER", JdeDataType.String, 20),
        new JdeField("YURCKN", "YURCKN", JdeDataType.Numeric),
        new JdeField("YUPRNS", "YUPRNS", JdeDataType.String, 2),
        new JdeField("YUAUBP", "YUAUBP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06156_0", "Primary Key on YUAN8, YUCKCN, YUICC, YUSCKC", new[] { "YUAN8", "YUCKCN", "YUICC", "YUSCKC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06156_10", "Index on YUAN8, YUPPED", new[] { "YUAN8", "YUPPED" }),
        new JdeIndex("F06156_11", "Index on YUAN8, YUCKCN, YUPPED", new[] { "YUAN8", "YUCKCN", "YUPPED" }),
        new JdeIndex("F06156_2", "Index on YUDOCM, YUCKD, YUGLBA", new[] { "YUDOCM", "YUCKD", "YUGLBA" }),
        new JdeIndex("F06156_3", "Index on YUAN8, YUCKD", new[] { "YUAN8", "YUCKD" }),
        new JdeIndex("F06156_4", "Index on YUGLBA, YUCKD, YUDOCM, YUCKCN, YUAN8", new[] { "YUGLBA", "YUCKD", "YUDOCM", "YUCKCN", "YUAN8" }),
        new JdeIndex("F06156_5", "Index on YUCKD, YUDOCM, YUGLBA", new[] { "YUCKD", "YUDOCM", "YUGLBA" }),
        new JdeIndex("F06156_6", "Index on YUGLBA, YUDOCM, YUCKD", new[] { "YUGLBA", "YUDOCM", "YUCKD" }),
        new JdeIndex("F06156_7", "Index on YUAN8, YUDOCM, YUGLBA", new[] { "YUAN8", "YUDOCM", "YUGLBA" }),
        new JdeIndex("F06156_8", "Index on YUHMCO, YUAN8, YUCKD", new[] { "YUHMCO", "YUAN8", "YUCKD" }),
        new JdeIndex("F06156_9", "Index on YUGLBA, YUDOCS, YUDOCM, YUCKD, YUCKCN, YUAN8, YUICS", new[] { "YUGLBA", "YUDOCS", "YUDOCM", "YUCKD", "YUCKCN", "YUAN8", "YUICS" })
    };
}
