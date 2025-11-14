using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47107T - .
/// </summary>
public class F47107T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UZAAID.
        /// </summary>
        public const string UZAAID = "UZAAID";

        /// <summary>
        /// UZBCRC.
        /// </summary>
        public const string UZBCRC = "UZBCRC";

        /// <summary>
        /// UZCORD.
        /// </summary>
        public const string UZCORD = "UZCORD";

        /// <summary>
        /// UZDCTO.
        /// </summary>
        public const string UZDCTO = "UZDCTO";

        /// <summary>
        /// UZDMBU.
        /// </summary>
        public const string UZDMBU = "UZDMBU";

        /// <summary>
        /// UZDOCO.
        /// </summary>
        public const string UZDOCO = "UZDOCO";

        /// <summary>
        /// UZEDBT.
        /// </summary>
        public const string UZEDBT = "UZEDBT";

        /// <summary>
        /// UZEDCT.
        /// </summary>
        public const string UZEDCT = "UZEDCT";

        /// <summary>
        /// UZEDDL.
        /// </summary>
        public const string UZEDDL = "UZEDDL";

        /// <summary>
        /// UZEDDT.
        /// </summary>
        public const string UZEDDT = "UZEDDT";

        /// <summary>
        /// UZEDER.
        /// </summary>
        public const string UZEDER = "UZEDER";

        /// <summary>
        /// UZEDFT.
        /// </summary>
        public const string UZEDFT = "UZEDFT";

        /// <summary>
        /// UZEDLN.
        /// </summary>
        public const string UZEDLN = "UZEDLN";

        /// <summary>
        /// UZEDOC.
        /// </summary>
        public const string UZEDOC = "UZEDOC";

        /// <summary>
        /// UZEDSP.
        /// </summary>
        public const string UZEDSP = "UZEDSP";

        /// <summary>
        /// UZEDSQ.
        /// </summary>
        public const string UZEDSQ = "UZEDSQ";

        /// <summary>
        /// UZEDST.
        /// </summary>
        public const string UZEDST = "UZEDST";

        /// <summary>
        /// UZEDTY.
        /// </summary>
        public const string UZEDTY = "UZEDTY";

        /// <summary>
        /// UZEKCO.
        /// </summary>
        public const string UZEKCO = "UZEKCO";

        /// <summary>
        /// UZHDBU.
        /// </summary>
        public const string UZHDBU = "UZHDBU";

        /// <summary>
        /// UZKCOO.
        /// </summary>
        public const string UZKCOO = "UZKCOO";

        /// <summary>
        /// UZLNID.
        /// </summary>
        public const string UZLNID = "UZLNID";

        /// <summary>
        /// UZMCLN.
        /// </summary>
        public const string UZMCLN = "UZMCLN";

        /// <summary>
        /// UZMERL.
        /// </summary>
        public const string UZMERL = "UZMERL";

        /// <summary>
        /// UZNUMB.
        /// </summary>
        public const string UZNUMB = "UZNUMB";

        /// <summary>
        /// UZODLN.
        /// </summary>
        public const string UZODLN = "UZODLN";

        /// <summary>
        /// UZOSEQ.
        /// </summary>
        public const string UZOSEQ = "UZOSEQ";

        /// <summary>
        /// UZPEND.
        /// </summary>
        public const string UZPEND = "UZPEND";

        /// <summary>
        /// UZPNID.
        /// </summary>
        public const string UZPNID = "UZPNID";

        /// <summary>
        /// UZPOE.
        /// </summary>
        public const string UZPOE = "UZPOE";

        /// <summary>
        /// UZRSDT.
        /// </summary>
        public const string UZRSDT = "UZRSDT";

        /// <summary>
        /// UZSFXO.
        /// </summary>
        public const string UZSFXO = "UZSFXO";

        /// <summary>
        /// UZSO16.
        /// </summary>
        public const string UZSO16 = "UZSO16";

        /// <summary>
        /// UZSO17.
        /// </summary>
        public const string UZSO17 = "UZSO17";

        /// <summary>
        /// UZSO18.
        /// </summary>
        public const string UZSO18 = "UZSO18";

        /// <summary>
        /// UZSO19.
        /// </summary>
        public const string UZSO19 = "UZSO19";

        /// <summary>
        /// UZSO20.
        /// </summary>
        public const string UZSO20 = "UZSO20";

        /// <summary>
        /// UZVR03.
        /// </summary>
        public const string UZVR03 = "UZVR03";

        /// <summary>
        /// UZXCTO.
        /// </summary>
        public const string UZXCTO = "UZXCTO";

        /// <summary>
        /// UZXDCK.
        /// </summary>
        public const string UZXDCK = "UZXDCK";

        /// <summary>
        /// UZXKCO.
        /// </summary>
        public const string UZXKCO = "UZXKCO";

        /// <summary>
        /// UZXLLN.
        /// </summary>
        public const string UZXLLN = "UZXLLN";

        /// <summary>
        /// UZXORN.
        /// </summary>
        public const string UZXORN = "UZXORN";

        /// <summary>
        /// UZXPTY.
        /// </summary>
        public const string UZXPTY = "UZXPTY";

        /// <summary>
        /// UZXSFX.
        /// </summary>
        public const string UZXSFX = "UZXSFX";

        /// <summary>
        /// UZUSER.
        /// </summary>
        public const string UZUSER = "UZUSER";

        /// <summary>
        /// UZPID.
        /// </summary>
        public const string UZPID = "UZPID";

        /// <summary>
        /// UZJOBN.
        /// </summary>
        public const string UZJOBN = "UZJOBN";

        /// <summary>
        /// UZUPMJ.
        /// </summary>
        public const string UZUPMJ = "UZUPMJ";

        /// <summary>
        /// UZTDAY.
        /// </summary>
        public const string UZTDAY = "UZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47107T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UZAAID", "UZAAID", JdeDataType.Numeric),
        new JdeField("UZBCRC", "UZBCRC", JdeDataType.String, 6),
        new JdeField("UZCORD", "UZCORD", JdeDataType.Numeric),
        new JdeField("UZDCTO", "UZDCTO", JdeDataType.String, 4),
        new JdeField("UZDMBU", "UZDMBU", JdeDataType.String, 24),
        new JdeField("UZDOCO", "UZDOCO", JdeDataType.Numeric),
        new JdeField("UZEDBT", "UZEDBT", JdeDataType.String, 30),
        new JdeField("UZEDCT", "UZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("UZEDDL", "UZEDDL", JdeDataType.Numeric),
        new JdeField("UZEDDT", "UZEDDT", JdeDataType.Numeric),
        new JdeField("UZEDER", "UZEDER", JdeDataType.String, 2),
        new JdeField("UZEDFT", "UZEDFT", JdeDataType.String, 20),
        new JdeField("UZEDLN", "UZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDOC", "UZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDSP", "UZEDSP", JdeDataType.String, 2),
        new JdeField("UZEDSQ", "UZEDSQ", JdeDataType.Numeric),
        new JdeField("UZEDST", "UZEDST", JdeDataType.String, 12),
        new JdeField("UZEDTY", "UZEDTY", JdeDataType.String, 2),
        new JdeField("UZEKCO", "UZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("UZHDBU", "UZHDBU", JdeDataType.String, 24),
        new JdeField("UZKCOO", "UZKCOO", JdeDataType.String, 10),
        new JdeField("UZLNID", "UZLNID", JdeDataType.Numeric),
        new JdeField("UZMCLN", "UZMCLN", JdeDataType.Numeric),
        new JdeField("UZMERL", "UZMERL", JdeDataType.String, 6),
        new JdeField("UZNUMB", "UZNUMB", JdeDataType.Numeric),
        new JdeField("UZODLN", "UZODLN", JdeDataType.Numeric),
        new JdeField("UZOSEQ", "UZOSEQ", JdeDataType.Numeric),
        new JdeField("UZPEND", "UZPEND", JdeDataType.String, 2),
        new JdeField("UZPNID", "UZPNID", JdeDataType.String, 30),
        new JdeField("UZPOE", "UZPOE", JdeDataType.String, 12),
        new JdeField("UZRSDT", "UZRSDT", JdeDataType.Numeric),
        new JdeField("UZSFXO", "UZSFXO", JdeDataType.String, 6),
        new JdeField("UZSO16", "UZSO16", JdeDataType.String, 2),
        new JdeField("UZSO17", "UZSO17", JdeDataType.String, 2),
        new JdeField("UZSO18", "UZSO18", JdeDataType.String, 2),
        new JdeField("UZSO19", "UZSO19", JdeDataType.String, 2),
        new JdeField("UZSO20", "UZSO20", JdeDataType.String, 2),
        new JdeField("UZVR03", "UZVR03", JdeDataType.String, 50),
        new JdeField("UZXCTO", "UZXCTO", JdeDataType.String, 4),
        new JdeField("UZXDCK", "UZXDCK", JdeDataType.String, 2),
        new JdeField("UZXKCO", "UZXKCO", JdeDataType.String, 10),
        new JdeField("UZXLLN", "UZXLLN", JdeDataType.Numeric),
        new JdeField("UZXORN", "UZXORN", JdeDataType.Numeric),
        new JdeField("UZXPTY", "UZXPTY", JdeDataType.Numeric),
        new JdeField("UZXSFX", "UZXSFX", JdeDataType.String, 6),
        new JdeField("UZUSER", "UZUSER", JdeDataType.String, 20),
        new JdeField("UZPID", "UZPID", JdeDataType.String, 20),
        new JdeField("UZJOBN", "UZJOBN", JdeDataType.String, 20),
        new JdeField("UZUPMJ", "UZUPMJ", JdeDataType.Numeric),
        new JdeField("UZTDAY", "UZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47107T_0", "Primary Key on UZEDOC, UZEDCT, UZEKCO, UZEDLN", new[] { "UZEDOC", "UZEDCT", "UZEKCO", "UZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
