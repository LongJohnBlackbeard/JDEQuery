using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471721 - .
/// </summary>
public class F471721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EUEDTY.
        /// </summary>
        public const string EUEDTY = "EUEDTY";

        /// <summary>
        /// EUEDSQ.
        /// </summary>
        public const string EUEDSQ = "EUEDSQ";

        /// <summary>
        /// EUEKCO.
        /// </summary>
        public const string EUEKCO = "EUEKCO";

        /// <summary>
        /// EUEDOC.
        /// </summary>
        public const string EUEDOC = "EUEDOC";

        /// <summary>
        /// EUEDCT.
        /// </summary>
        public const string EUEDCT = "EUEDCT";

        /// <summary>
        /// EUEDLN.
        /// </summary>
        public const string EUEDLN = "EUEDLN";

        /// <summary>
        /// EUEDST.
        /// </summary>
        public const string EUEDST = "EUEDST";

        /// <summary>
        /// EUEDFT.
        /// </summary>
        public const string EUEDFT = "EUEDFT";

        /// <summary>
        /// EUEDDT.
        /// </summary>
        public const string EUEDDT = "EUEDDT";

        /// <summary>
        /// EUEDER.
        /// </summary>
        public const string EUEDER = "EUEDER";

        /// <summary>
        /// EUEDDL.
        /// </summary>
        public const string EUEDDL = "EUEDDL";

        /// <summary>
        /// EUEDSP.
        /// </summary>
        public const string EUEDSP = "EUEDSP";

        /// <summary>
        /// EUEDBT.
        /// </summary>
        public const string EUEDBT = "EUEDBT";

        /// <summary>
        /// EUEDSLN.
        /// </summary>
        public const string EUEDSLN = "EUEDSLN";

        /// <summary>
        /// EUTYDT.
        /// </summary>
        public const string EUTYDT = "EUTYDT";

        /// <summary>
        /// EUKY.
        /// </summary>
        public const string EUKY = "EUKY";

        /// <summary>
        /// EUUORG.
        /// </summary>
        public const string EUUORG = "EUUORG";

        /// <summary>
        /// EUUPDJ.
        /// </summary>
        public const string EUUPDJ = "EUUPDJ";

        /// <summary>
        /// EUAMTU.
        /// </summary>
        public const string EUAMTU = "EUAMTU";

        /// <summary>
        /// EUUPTM.
        /// </summary>
        public const string EUUPTM = "EUUPTM";

        /// <summary>
        /// EUAMTV.
        /// </summary>
        public const string EUAMTV = "EUAMTV";

        /// <summary>
        /// EUAN8.
        /// </summary>
        public const string EUAN8 = "EUAN8";

        /// <summary>
        /// EUDYUD.
        /// </summary>
        public const string EUDYUD = "EUDYUD";

        /// <summary>
        /// EURMK.
        /// </summary>
        public const string EURMK = "EURMK";

        /// <summary>
        /// EURMK2.
        /// </summary>
        public const string EURMK2 = "EURMK2";

        /// <summary>
        /// EURMK3.
        /// </summary>
        public const string EURMK3 = "EURMK3";

        /// <summary>
        /// EUURCD.
        /// </summary>
        public const string EUURCD = "EUURCD";

        /// <summary>
        /// EUURDT.
        /// </summary>
        public const string EUURDT = "EUURDT";

        /// <summary>
        /// EUURAT.
        /// </summary>
        public const string EUURAT = "EUURAT";

        /// <summary>
        /// EUURAB.
        /// </summary>
        public const string EUURAB = "EUURAB";

        /// <summary>
        /// EUURRF.
        /// </summary>
        public const string EUURRF = "EUURRF";

        /// <summary>
        /// EUUSER.
        /// </summary>
        public const string EUUSER = "EUUSER";

        /// <summary>
        /// EUPID.
        /// </summary>
        public const string EUPID = "EUPID";

        /// <summary>
        /// EUJOBN.
        /// </summary>
        public const string EUJOBN = "EUJOBN";

        /// <summary>
        /// EUUPMJ.
        /// </summary>
        public const string EUUPMJ = "EUUPMJ";

        /// <summary>
        /// EUTDAY.
        /// </summary>
        public const string EUTDAY = "EUTDAY";

        /// <summary>
        /// EUGAN8.
        /// </summary>
        public const string EUGAN8 = "EUGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F471721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EUEDTY", "EUEDTY", JdeDataType.String, 2),
        new JdeField("EUEDSQ", "EUEDSQ", JdeDataType.Numeric),
        new JdeField("EUEKCO", "EUEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EUEDOC", "EUEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EUEDCT", "EUEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EUEDLN", "EUEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EUEDST", "EUEDST", JdeDataType.String, 12),
        new JdeField("EUEDFT", "EUEDFT", JdeDataType.String, 20),
        new JdeField("EUEDDT", "EUEDDT", JdeDataType.Numeric),
        new JdeField("EUEDER", "EUEDER", JdeDataType.String, 2),
        new JdeField("EUEDDL", "EUEDDL", JdeDataType.Numeric),
        new JdeField("EUEDSP", "EUEDSP", JdeDataType.String, 2),
        new JdeField("EUEDBT", "EUEDBT", JdeDataType.String, 30),
        new JdeField("EUEDSLN", "EUEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EUTYDT", "EUTYDT", JdeDataType.String, 4, true, true),
        new JdeField("EUKY", "EUKY", JdeDataType.String, 20, true, true),
        new JdeField("EUUORG", "EUUORG", JdeDataType.Numeric),
        new JdeField("EUUPDJ", "EUUPDJ", JdeDataType.Numeric),
        new JdeField("EUAMTU", "EUAMTU", JdeDataType.Numeric),
        new JdeField("EUUPTM", "EUUPTM", JdeDataType.Numeric),
        new JdeField("EUAMTV", "EUAMTV", JdeDataType.Numeric),
        new JdeField("EUAN8", "EUAN8", JdeDataType.Numeric),
        new JdeField("EUDYUD", "EUDYUD", JdeDataType.Numeric),
        new JdeField("EURMK", "EURMK", JdeDataType.String, 60),
        new JdeField("EURMK2", "EURMK2", JdeDataType.String, 60),
        new JdeField("EURMK3", "EURMK3", JdeDataType.String, 100),
        new JdeField("EUURCD", "EUURCD", JdeDataType.String, 4),
        new JdeField("EUURDT", "EUURDT", JdeDataType.Numeric),
        new JdeField("EUURAT", "EUURAT", JdeDataType.Numeric),
        new JdeField("EUURAB", "EUURAB", JdeDataType.Numeric),
        new JdeField("EUURRF", "EUURRF", JdeDataType.String, 30),
        new JdeField("EUUSER", "EUUSER", JdeDataType.String, 20),
        new JdeField("EUPID", "EUPID", JdeDataType.String, 20),
        new JdeField("EUJOBN", "EUJOBN", JdeDataType.String, 20),
        new JdeField("EUUPMJ", "EUUPMJ", JdeDataType.Numeric),
        new JdeField("EUTDAY", "EUTDAY", JdeDataType.Numeric),
        new JdeField("EUGAN8", "EUGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471721_0", "Primary Key on EUEDOC, EUEDCT, EUEKCO, EUEDLN, EUEDSLN, EUTYDT, EUKY", new[] { "EUEDOC", "EUEDCT", "EUEKCO", "EUEDLN", "EUEDSLN", "EUTYDT", "EUKY" }, isUnique: true, isPrimaryKey: true)
    };
}
