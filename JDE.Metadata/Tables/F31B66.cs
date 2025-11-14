using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B66 - .
/// </summary>
public class F31B66 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTWOPID.
        /// </summary>
        public const string BTWOPID = "BTWOPID";

        /// <summary>
        /// BTLNID.
        /// </summary>
        public const string BTLNID = "BTLNID";

        /// <summary>
        /// BTMCU.
        /// </summary>
        public const string BTMCU = "BTMCU";

        /// <summary>
        /// BTWCOPCD.
        /// </summary>
        public const string BTWCOPCD = "BTWCOPCD";

        /// <summary>
        /// BTWOCDATE.
        /// </summary>
        public const string BTWOCDATE = "BTWOCDATE";

        /// <summary>
        /// BTWLOTN.
        /// </summary>
        public const string BTWLOTN = "BTWLOTN";

        /// <summary>
        /// BTMATYP.
        /// </summary>
        public const string BTMATYP = "BTMATYP";

        /// <summary>
        /// BTWISSC.
        /// </summary>
        public const string BTWISSC = "BTWISSC";

        /// <summary>
        /// BTU.
        /// </summary>
        public const string BTU = "BTU";

        /// <summary>
        /// BTWVUM.
        /// </summary>
        public const string BTWVUM = "BTWVUM";

        /// <summary>
        /// BTUNCS.
        /// </summary>
        public const string BTUNCS = "BTUNCS";

        /// <summary>
        /// BTAA.
        /// </summary>
        public const string BTAA = "BTAA";

        /// <summary>
        /// BTDCT.
        /// </summary>
        public const string BTDCT = "BTDCT";

        /// <summary>
        /// BTKCO.
        /// </summary>
        public const string BTKCO = "BTKCO";

        /// <summary>
        /// BTDOC.
        /// </summary>
        public const string BTDOC = "BTDOC";

        /// <summary>
        /// BTDGL.
        /// </summary>
        public const string BTDGL = "BTDGL";

        /// <summary>
        /// BTGLPT.
        /// </summary>
        public const string BTGLPT = "BTGLPT";

        /// <summary>
        /// BTITM.
        /// </summary>
        public const string BTITM = "BTITM";

        /// <summary>
        /// BTWPA.
        /// </summary>
        public const string BTWPA = "BTWPA";

        /// <summary>
        /// BTWTEMP.
        /// </summary>
        public const string BTWTEMP = "BTWTEMP";

        /// <summary>
        /// BTWLN.
        /// </summary>
        public const string BTWLN = "BTWLN";

        /// <summary>
        /// BTWTT.
        /// </summary>
        public const string BTWTT = "BTWTT";

        /// <summary>
        /// BTWPF.
        /// </summary>
        public const string BTWPF = "BTWPF";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";

        /// <summary>
        /// BTJOBN.
        /// </summary>
        public const string BTJOBN = "BTJOBN";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTTDAY.
        /// </summary>
        public const string BTTDAY = "BTTDAY";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTWCFGID.
        /// </summary>
        public const string BTWCFGID = "BTWCFGID";

        /// <summary>
        /// BTEURID.
        /// </summary>
        public const string BTEURID = "BTEURID";

        /// <summary>
        /// BTSTUNCS.
        /// </summary>
        public const string BTSTUNCS = "BTSTUNCS";

        /// <summary>
        /// BTSTDAA.
        /// </summary>
        public const string BTSTDAA = "BTSTDAA";

        /// <summary>
        /// BTWOPN.
        /// </summary>
        public const string BTWOPN = "BTWOPN";

        /// <summary>
        /// BTWAB.
        /// </summary>
        public const string BTWAB = "BTWAB";

        /// <summary>
        /// BTWMDT.
        /// </summary>
        public const string BTWMDT = "BTWMDT";

        /// <summary>
        /// BTWNUM.
        /// </summary>
        public const string BTWNUM = "BTWNUM";

        /// <summary>
        /// BTWCD.
        /// </summary>
        public const string BTWCD = "BTWCD";

        /// <summary>
        /// BTWRF.
        /// </summary>
        public const string BTWRF = "BTWRF";

        /// <summary>
        /// BTGFL1.
        /// </summary>
        public const string BTGFL1 = "BTGFL1";

        /// <summary>
        /// BTGFL2.
        /// </summary>
        public const string BTGFL2 = "BTGFL2";

        /// <summary>
        /// BTWOPRVF.
        /// </summary>
        public const string BTWOPRVF = "BTWOPRVF";

        /// <summary>
        /// BTWTBOQTY.
        /// </summary>
        public const string BTWTBOQTY = "BTWTBOQTY";

        /// <summary>
        /// BTWDLOSFL.
        /// </summary>
        public const string BTWDLOSFL = "BTWDLOSFL";

        /// <summary>
        /// BTWMVF.
        /// </summary>
        public const string BTWMVF = "BTWMVF";

        /// <summary>
        /// BTWFTF.
        /// </summary>
        public const string BTWFTF = "BTWFTF";

        /// <summary>
        /// BTWCYVF.
        /// </summary>
        public const string BTWCYVF = "BTWCYVF";

        /// <summary>
        /// BTWOGLF.
        /// </summary>
        public const string BTWOGLF = "BTWOGLF";

        /// <summary>
        /// BTWFVTY.
        /// </summary>
        public const string BTWFVTY = "BTWFVTY";

        /// <summary>
        /// BTWTVTY.
        /// </summary>
        public const string BTWTVTY = "BTWTVTY";

        /// <summary>
        /// BTIDOC.
        /// </summary>
        public const string BTIDOC = "BTIDOC";

        /// <summary>
        /// BTIDCT.
        /// </summary>
        public const string BTIDCT = "BTIDCT";

        /// <summary>
        /// BTIKCO.
        /// </summary>
        public const string BTIKCO = "BTIKCO";

        /// <summary>
        /// BTILNID.
        /// </summary>
        public const string BTILNID = "BTILNID";

        /// <summary>
        /// BTGPBT.
        /// </summary>
        public const string BTGPBT = "BTGPBT";

        /// <summary>
        /// BTITPTY.
        /// </summary>
        public const string BTITPTY = "BTITPTY";

        /// <summary>
        /// BTLOCN.
        /// </summary>
        public const string BTLOCN = "BTLOCN";

        /// <summary>
        /// BTLOTN.
        /// </summary>
        public const string BTLOTN = "BTLOTN";

        /// <summary>
        /// BTWAEJDT.
        /// </summary>
        public const string BTWAEJDT = "BTWAEJDT";

        /// <summary>
        /// BTWBALT.
        /// </summary>
        public const string BTWBALT = "BTWBALT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B66";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTWOPID", "BTWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("BTLNID", "BTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BTMCU", "BTMCU", JdeDataType.String, 24),
        new JdeField("BTWCOPCD", "BTWCOPCD", JdeDataType.String, 20),
        new JdeField("BTWOCDATE", "BTWOCDATE", JdeDataType.Numeric),
        new JdeField("BTWLOTN", "BTWLOTN", JdeDataType.String, 60),
        new JdeField("BTMATYP", "BTMATYP", JdeDataType.String, 8),
        new JdeField("BTWISSC", "BTWISSC", JdeDataType.String, 12),
        new JdeField("BTU", "BTU", JdeDataType.Numeric),
        new JdeField("BTWVUM", "BTWVUM", JdeDataType.String, 6),
        new JdeField("BTUNCS", "BTUNCS", JdeDataType.Numeric),
        new JdeField("BTAA", "BTAA", JdeDataType.Numeric),
        new JdeField("BTDCT", "BTDCT", JdeDataType.String, 4),
        new JdeField("BTKCO", "BTKCO", JdeDataType.String, 10),
        new JdeField("BTDOC", "BTDOC", JdeDataType.Numeric),
        new JdeField("BTDGL", "BTDGL", JdeDataType.Numeric),
        new JdeField("BTGLPT", "BTGLPT", JdeDataType.String, 8),
        new JdeField("BTITM", "BTITM", JdeDataType.Numeric),
        new JdeField("BTWPA", "BTWPA", JdeDataType.Numeric),
        new JdeField("BTWTEMP", "BTWTEMP", JdeDataType.Numeric),
        new JdeField("BTWLN", "BTWLN", JdeDataType.Numeric),
        new JdeField("BTWTT", "BTWTT", JdeDataType.String, 2),
        new JdeField("BTWPF", "BTWPF", JdeDataType.String, 2),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20),
        new JdeField("BTJOBN", "BTJOBN", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTTDAY", "BTTDAY", JdeDataType.Numeric),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTWCFGID", "BTWCFGID", JdeDataType.Numeric),
        new JdeField("BTEURID", "BTEURID", JdeDataType.Numeric),
        new JdeField("BTSTUNCS", "BTSTUNCS", JdeDataType.Numeric),
        new JdeField("BTSTDAA", "BTSTDAA", JdeDataType.Numeric),
        new JdeField("BTWOPN", "BTWOPN", JdeDataType.Numeric),
        new JdeField("BTWAB", "BTWAB", JdeDataType.Numeric),
        new JdeField("BTWMDT", "BTWMDT", JdeDataType.Numeric),
        new JdeField("BTWNUM", "BTWNUM", JdeDataType.Numeric),
        new JdeField("BTWCD", "BTWCD", JdeDataType.String, 6),
        new JdeField("BTWRF", "BTWRF", JdeDataType.String, 60),
        new JdeField("BTGFL1", "BTGFL1", JdeDataType.String, 2),
        new JdeField("BTGFL2", "BTGFL2", JdeDataType.String, 2),
        new JdeField("BTWOPRVF", "BTWOPRVF", JdeDataType.String, 2),
        new JdeField("BTWTBOQTY", "BTWTBOQTY", JdeDataType.Numeric),
        new JdeField("BTWDLOSFL", "BTWDLOSFL", JdeDataType.String, 2),
        new JdeField("BTWMVF", "BTWMVF", JdeDataType.String, 2),
        new JdeField("BTWFTF", "BTWFTF", JdeDataType.String, 2),
        new JdeField("BTWCYVF", "BTWCYVF", JdeDataType.String, 2),
        new JdeField("BTWOGLF", "BTWOGLF", JdeDataType.String, 2),
        new JdeField("BTWFVTY", "BTWFVTY", JdeDataType.String, 2),
        new JdeField("BTWTVTY", "BTWTVTY", JdeDataType.String, 2),
        new JdeField("BTIDOC", "BTIDOC", JdeDataType.Numeric),
        new JdeField("BTIDCT", "BTIDCT", JdeDataType.String, 4),
        new JdeField("BTIKCO", "BTIKCO", JdeDataType.String, 10),
        new JdeField("BTILNID", "BTILNID", JdeDataType.Numeric),
        new JdeField("BTGPBT", "BTGPBT", JdeDataType.Numeric),
        new JdeField("BTITPTY", "BTITPTY", JdeDataType.Numeric),
        new JdeField("BTLOCN", "BTLOCN", JdeDataType.String, 40),
        new JdeField("BTLOTN", "BTLOTN", JdeDataType.String, 60),
        new JdeField("BTWAEJDT", "BTWAEJDT", JdeDataType.Numeric),
        new JdeField("BTWBALT", "BTWBALT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B66_0", "Primary Key on BTWOPID, BTLNID", new[] { "BTWOPID", "BTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B66_2", "Index on BTWOPID, SYS_NC00060$", new[] { "BTWOPID", "SYS_NC00060$" })
    };
}
