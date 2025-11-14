using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A24 - .
/// </summary>
public class F76A24 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IEDCT.
        /// </summary>
        public const string IEDCT = "IEDCT";

        /// <summary>
        /// IEDOC.
        /// </summary>
        public const string IEDOC = "IEDOC";

        /// <summary>
        /// IEKCO.
        /// </summary>
        public const string IEKCO = "IEKCO";

        /// <summary>
        /// IESFX.
        /// </summary>
        public const string IESFX = "IESFX";

        /// <summary>
        /// IEAN8.
        /// </summary>
        public const string IEAN8 = "IEAN8";

        /// <summary>
        /// IECRCD.
        /// </summary>
        public const string IECRCD = "IECRCD";

        /// <summary>
        /// IECRRM.
        /// </summary>
        public const string IECRRM = "IECRRM";

        /// <summary>
        /// IECRR.
        /// </summary>
        public const string IECRR = "IECRR";

        /// <summary>
        /// IEADGI.
        /// </summary>
        public const string IEADGI = "IEADGI";

        /// <summary>
        /// IEACEM.
        /// </summary>
        public const string IEACEM = "IEACEM";

        /// <summary>
        /// IEAGRP.
        /// </summary>
        public const string IEAGRP = "IEAGRP";

        /// <summary>
        /// IEAINW.
        /// </summary>
        public const string IEAINW = "IEAINW";

        /// <summary>
        /// IEPNO.
        /// </summary>
        public const string IEPNO = "IEPNO";

        /// <summary>
        /// IEDIVJ.
        /// </summary>
        public const string IEDIVJ = "IEDIVJ";

        /// <summary>
        /// IEACIS.
        /// </summary>
        public const string IEACIS = "IEACIS";

        /// <summary>
        /// IEAG.
        /// </summary>
        public const string IEAG = "IEAG";

        /// <summary>
        /// IEACR.
        /// </summary>
        public const string IEACR = "IEACR";

        /// <summary>
        /// IEDOCM.
        /// </summary>
        public const string IEDOCM = "IEDOCM";

        /// <summary>
        /// IERMK.
        /// </summary>
        public const string IERMK = "IERMK";

        /// <summary>
        /// IEVR01.
        /// </summary>
        public const string IEVR01 = "IEVR01";

        /// <summary>
        /// IERCPD.
        /// </summary>
        public const string IERCPD = "IERCPD";

        /// <summary>
        /// IEMT.
        /// </summary>
        public const string IEMT = "IEMT";

        /// <summary>
        /// IEYR.
        /// </summary>
        public const string IEYR = "IEYR";

        /// <summary>
        /// IEAINC.
        /// </summary>
        public const string IEAINC = "IEAINC";

        /// <summary>
        /// IEURAT.
        /// </summary>
        public const string IEURAT = "IEURAT";

        /// <summary>
        /// IEURC1.
        /// </summary>
        public const string IEURC1 = "IEURC1";

        /// <summary>
        /// IEURRF.
        /// </summary>
        public const string IEURRF = "IEURRF";

        /// <summary>
        /// IEURAB.
        /// </summary>
        public const string IEURAB = "IEURAB";

        /// <summary>
        /// IEURDT.
        /// </summary>
        public const string IEURDT = "IEURDT";

        /// <summary>
        /// IETORG.
        /// </summary>
        public const string IETORG = "IETORG";

        /// <summary>
        /// IEUSER.
        /// </summary>
        public const string IEUSER = "IEUSER";

        /// <summary>
        /// IEPID.
        /// </summary>
        public const string IEPID = "IEPID";

        /// <summary>
        /// IEUPMJ.
        /// </summary>
        public const string IEUPMJ = "IEUPMJ";

        /// <summary>
        /// IEUPMT.
        /// </summary>
        public const string IEUPMT = "IEUPMT";

        /// <summary>
        /// IECTID.
        /// </summary>
        public const string IECTID = "IECTID";

        /// <summary>
        /// IEADGI1.
        /// </summary>
        public const string IEADGI1 = "IEADGI1";

        /// <summary>
        /// IEACEM1.
        /// </summary>
        public const string IEACEM1 = "IEACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A24";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IEDCT", "IEDCT", JdeDataType.String, 4, true, true),
        new JdeField("IEDOC", "IEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IEKCO", "IEKCO", JdeDataType.String, 10, true, true),
        new JdeField("IESFX", "IESFX", JdeDataType.String, 6, true, true),
        new JdeField("IEAN8", "IEAN8", JdeDataType.Numeric),
        new JdeField("IECRCD", "IECRCD", JdeDataType.String, 6),
        new JdeField("IECRRM", "IECRRM", JdeDataType.String, 2),
        new JdeField("IECRR", "IECRR", JdeDataType.Numeric),
        new JdeField("IEADGI", "IEADGI", JdeDataType.String, 4),
        new JdeField("IEACEM", "IEACEM", JdeDataType.String, 8),
        new JdeField("IEAGRP", "IEAGRP", JdeDataType.String, 2),
        new JdeField("IEAINW", "IEAINW", JdeDataType.String, 16),
        new JdeField("IEPNO", "IEPNO", JdeDataType.Numeric),
        new JdeField("IEDIVJ", "IEDIVJ", JdeDataType.Numeric),
        new JdeField("IEACIS", "IEACIS", JdeDataType.String, 4),
        new JdeField("IEAG", "IEAG", JdeDataType.Numeric),
        new JdeField("IEACR", "IEACR", JdeDataType.Numeric),
        new JdeField("IEDOCM", "IEDOCM", JdeDataType.Numeric),
        new JdeField("IERMK", "IERMK", JdeDataType.String, 60),
        new JdeField("IEVR01", "IEVR01", JdeDataType.String, 50),
        new JdeField("IERCPD", "IERCPD", JdeDataType.Numeric),
        new JdeField("IEMT", "IEMT", JdeDataType.Numeric),
        new JdeField("IEYR", "IEYR", JdeDataType.Numeric),
        new JdeField("IEAINC", "IEAINC", JdeDataType.String, 2),
        new JdeField("IEURAT", "IEURAT", JdeDataType.Numeric),
        new JdeField("IEURC1", "IEURC1", JdeDataType.String, 6),
        new JdeField("IEURRF", "IEURRF", JdeDataType.String, 30),
        new JdeField("IEURAB", "IEURAB", JdeDataType.Numeric),
        new JdeField("IEURDT", "IEURDT", JdeDataType.Numeric),
        new JdeField("IETORG", "IETORG", JdeDataType.String, 20),
        new JdeField("IEUSER", "IEUSER", JdeDataType.String, 20),
        new JdeField("IEPID", "IEPID", JdeDataType.String, 20),
        new JdeField("IEUPMJ", "IEUPMJ", JdeDataType.Numeric),
        new JdeField("IEUPMT", "IEUPMT", JdeDataType.Numeric),
        new JdeField("IECTID", "IECTID", JdeDataType.String, 30),
        new JdeField("IEADGI1", "IEADGI1", JdeDataType.String, 20),
        new JdeField("IEACEM1", "IEACEM1", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A24_0", "Primary Key on IEDCT, IEDOC, IEKCO, IESFX", new[] { "IEDCT", "IEDOC", "IEKCO", "IESFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A24_2", "Index on IEACEM1, IEAINW, IEAGRP, IEADGI1, IEAN8, IEACEM, IEADGI", new[] { "IEACEM1", "IEAINW", "IEAGRP", "IEADGI1", "IEAN8", "IEACEM", "IEADGI" }),
        new JdeIndex("F76A24_3", "Index on IEAN8, IEVR01", new[] { "IEAN8", "IEVR01" })
    };
}
