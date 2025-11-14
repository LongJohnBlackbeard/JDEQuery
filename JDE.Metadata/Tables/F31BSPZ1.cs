using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31BSPZ1 - .
/// </summary>
public class F31BSPZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STEDUS.
        /// </summary>
        public const string STEDUS = "STEDUS";

        /// <summary>
        /// STEDBT.
        /// </summary>
        public const string STEDBT = "STEDBT";

        /// <summary>
        /// STEDTN.
        /// </summary>
        public const string STEDTN = "STEDTN";

        /// <summary>
        /// STEDLN.
        /// </summary>
        public const string STEDLN = "STEDLN";

        /// <summary>
        /// STEDSP.
        /// </summary>
        public const string STEDSP = "STEDSP";

        /// <summary>
        /// STEDDT.
        /// </summary>
        public const string STEDDT = "STEDDT";

        /// <summary>
        /// STDRIN.
        /// </summary>
        public const string STDRIN = "STDRIN";

        /// <summary>
        /// STASNBR.
        /// </summary>
        public const string STASNBR = "STASNBR";

        /// <summary>
        /// STQTST.
        /// </summary>
        public const string STQTST = "STQTST";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STQVAL.
        /// </summary>
        public const string STQVAL = "STQVAL";

        /// <summary>
        /// STMUSE.
        /// </summary>
        public const string STMUSE = "STMUSE";

        /// <summary>
        /// STQDAT.
        /// </summary>
        public const string STQDAT = "STQDAT";

        /// <summary>
        /// STRSEXPD.
        /// </summary>
        public const string STRSEXPD = "STRSEXPD";

        /// <summary>
        /// STSMPTYP.
        /// </summary>
        public const string STSMPTYP = "STSMPTYP";

        /// <summary>
        /// STSMPSTS.
        /// </summary>
        public const string STSMPSTS = "STSMPSTS";

        /// <summary>
        /// STSMPMTHD.
        /// </summary>
        public const string STSMPMTHD = "STSMPMTHD";

        /// <summary>
        /// STSMPCNTR.
        /// </summary>
        public const string STSMPCNTR = "STSMPCNTR";

        /// <summary>
        /// STSMPCLSR.
        /// </summary>
        public const string STSMPCLSR = "STSMPCLSR";

        /// <summary>
        /// STQSSZ.
        /// </summary>
        public const string STQSSZ = "STQSSZ";

        /// <summary>
        /// STQUM.
        /// </summary>
        public const string STQUM = "STQUM";

        /// <summary>
        /// STSMPLR.
        /// </summary>
        public const string STSMPLR = "STSMPLR";

        /// <summary>
        /// STUSMPDT.
        /// </summary>
        public const string STUSMPDT = "STUSMPDT";

        /// <summary>
        /// STUSRQDT.
        /// </summary>
        public const string STUSRQDT = "STUSRQDT";

        /// <summary>
        /// STDLAB.
        /// </summary>
        public const string STDLAB = "STDLAB";

        /// <summary>
        /// STWMDT.
        /// </summary>
        public const string STWMDT = "STWMDT";

        /// <summary>
        /// STWNUM.
        /// </summary>
        public const string STWNUM = "STWNUM";

        /// <summary>
        /// STWAB.
        /// </summary>
        public const string STWAB = "STWAB";

        /// <summary>
        /// STWCD.
        /// </summary>
        public const string STWCD = "STWCD";

        /// <summary>
        /// STWRF.
        /// </summary>
        public const string STWRF = "STWRF";

        /// <summary>
        /// STURAT.
        /// </summary>
        public const string STURAT = "STURAT";

        /// <summary>
        /// STURCD.
        /// </summary>
        public const string STURCD = "STURCD";

        /// <summary>
        /// STURDT.
        /// </summary>
        public const string STURDT = "STURDT";

        /// <summary>
        /// STURRF.
        /// </summary>
        public const string STURRF = "STURRF";

        /// <summary>
        /// STURAB.
        /// </summary>
        public const string STURAB = "STURAB";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STBSNBR.
        /// </summary>
        public const string STBSNBR = "STBSNBR";

        /// <summary>
        /// STTYTN.
        /// </summary>
        public const string STTYTN = "STTYTN";

        /// <summary>
        /// STTNAC.
        /// </summary>
        public const string STTNAC = "STTNAC";

        /// <summary>
        /// STWCRTR.
        /// </summary>
        public const string STWCRTR = "STWCRTR";

        /// <summary>
        /// STWAPRN.
        /// </summary>
        public const string STWAPRN = "STWAPRN";
    }

    /// <inheritdoc />
    public override string TableName => "F31BSPZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STEDUS", "STEDUS", JdeDataType.String, 20, true, true),
        new JdeField("STEDBT", "STEDBT", JdeDataType.String, 30, true, true),
        new JdeField("STEDTN", "STEDTN", JdeDataType.String, 44, true, true),
        new JdeField("STEDLN", "STEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("STEDSP", "STEDSP", JdeDataType.String, 2),
        new JdeField("STEDDT", "STEDDT", JdeDataType.Numeric),
        new JdeField("STDRIN", "STDRIN", JdeDataType.String, 2),
        new JdeField("STASNBR", "STASNBR", JdeDataType.String, 40),
        new JdeField("STQTST", "STQTST", JdeDataType.String, 50),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24),
        new JdeField("STQVAL", "STQVAL", JdeDataType.String, 30),
        new JdeField("STMUSE", "STMUSE", JdeDataType.String, 20),
        new JdeField("STQDAT", "STQDAT", JdeDataType.Numeric),
        new JdeField("STRSEXPD", "STRSEXPD", JdeDataType.Numeric),
        new JdeField("STSMPTYP", "STSMPTYP", JdeDataType.String, 4),
        new JdeField("STSMPSTS", "STSMPSTS", JdeDataType.String, 6),
        new JdeField("STSMPMTHD", "STSMPMTHD", JdeDataType.String, 20),
        new JdeField("STSMPCNTR", "STSMPCNTR", JdeDataType.String, 20),
        new JdeField("STSMPCLSR", "STSMPCLSR", JdeDataType.String, 20),
        new JdeField("STQSSZ", "STQSSZ", JdeDataType.Numeric),
        new JdeField("STQUM", "STQUM", JdeDataType.String, 6),
        new JdeField("STSMPLR", "STSMPLR", JdeDataType.String, 20),
        new JdeField("STUSMPDT", "STUSMPDT", JdeDataType.Date),
        new JdeField("STUSRQDT", "STUSRQDT", JdeDataType.Date),
        new JdeField("STDLAB", "STDLAB", JdeDataType.Numeric),
        new JdeField("STWMDT", "STWMDT", JdeDataType.Numeric),
        new JdeField("STWNUM", "STWNUM", JdeDataType.Numeric),
        new JdeField("STWAB", "STWAB", JdeDataType.Numeric),
        new JdeField("STWCD", "STWCD", JdeDataType.String, 6),
        new JdeField("STWRF", "STWRF", JdeDataType.String, 60),
        new JdeField("STURAT", "STURAT", JdeDataType.Numeric),
        new JdeField("STURCD", "STURCD", JdeDataType.String, 4),
        new JdeField("STURDT", "STURDT", JdeDataType.Numeric),
        new JdeField("STURRF", "STURRF", JdeDataType.String, 30),
        new JdeField("STURAB", "STURAB", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STBSNBR", "STBSNBR", JdeDataType.Numeric),
        new JdeField("STTYTN", "STTYTN", JdeDataType.String, 16),
        new JdeField("STTNAC", "STTNAC", JdeDataType.String, 4),
        new JdeField("STWCRTR", "STWCRTR", JdeDataType.Numeric),
        new JdeField("STWAPRN", "STWAPRN", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31BSPZ1_0", "Primary Key on STEDUS, STEDBT, STEDTN, STEDLN", new[] { "STEDUS", "STEDBT", "STEDTN", "STEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31BSPZ1_2", "Index on STBSNBR, STQTST, STMCU", new[] { "STBSNBR", "STQTST", "STMCU" }),
        new JdeIndex("F31BSPZ1_3", "Index on STWAPRN", new[] { "STWAPRN" })
    };
}
