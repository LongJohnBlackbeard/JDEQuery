using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A22P - .
/// </summary>
public class F76A22P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDKCO.
        /// </summary>
        public const string IDKCO = "IDKCO";

        /// <summary>
        /// IDDCT.
        /// </summary>
        public const string IDDCT = "IDDCT";

        /// <summary>
        /// IDDOC.
        /// </summary>
        public const string IDDOC = "IDDOC";

        /// <summary>
        /// IDPNO.
        /// </summary>
        public const string IDPNO = "IDPNO";

        /// <summary>
        /// IDADGI.
        /// </summary>
        public const string IDADGI = "IDADGI";

        /// <summary>
        /// IDACEM.
        /// </summary>
        public const string IDACEM = "IDACEM";

        /// <summary>
        /// IDAGRP.
        /// </summary>
        public const string IDAGRP = "IDAGRP";

        /// <summary>
        /// IDAINW.
        /// </summary>
        public const string IDAINW = "IDAINW";

        /// <summary>
        /// IDAG.
        /// </summary>
        public const string IDAG = "IDAG";

        /// <summary>
        /// IDACR.
        /// </summary>
        public const string IDACR = "IDACR";

        /// <summary>
        /// IDDDJ.
        /// </summary>
        public const string IDDDJ = "IDDDJ";

        /// <summary>
        /// IDACIS.
        /// </summary>
        public const string IDACIS = "IDACIS";

        /// <summary>
        /// IDDL01.
        /// </summary>
        public const string IDDL01 = "IDDL01";

        /// <summary>
        /// IDDL02.
        /// </summary>
        public const string IDDL02 = "IDDL02";

        /// <summary>
        /// IDURRF.
        /// </summary>
        public const string IDURRF = "IDURRF";

        /// <summary>
        /// IDURCD.
        /// </summary>
        public const string IDURCD = "IDURCD";

        /// <summary>
        /// IDURDT.
        /// </summary>
        public const string IDURDT = "IDURDT";

        /// <summary>
        /// IDURAT.
        /// </summary>
        public const string IDURAT = "IDURAT";

        /// <summary>
        /// IDURAB.
        /// </summary>
        public const string IDURAB = "IDURAB";

        /// <summary>
        /// IDCTID.
        /// </summary>
        public const string IDCTID = "IDCTID";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDUPMT.
        /// </summary>
        public const string IDUPMT = "IDUPMT";

        /// <summary>
        /// IDADGI1.
        /// </summary>
        public const string IDADGI1 = "IDADGI1";

        /// <summary>
        /// IDACEM1.
        /// </summary>
        public const string IDACEM1 = "IDACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A22P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDKCO", "IDKCO", JdeDataType.String, 10, true, true),
        new JdeField("IDDCT", "IDDCT", JdeDataType.String, 4, true, true),
        new JdeField("IDDOC", "IDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IDPNO", "IDPNO", JdeDataType.Numeric, null, true, true),
        new JdeField("IDADGI", "IDADGI", JdeDataType.String, 4),
        new JdeField("IDACEM", "IDACEM", JdeDataType.String, 8),
        new JdeField("IDAGRP", "IDAGRP", JdeDataType.String, 2),
        new JdeField("IDAINW", "IDAINW", JdeDataType.String, 16),
        new JdeField("IDAG", "IDAG", JdeDataType.Numeric),
        new JdeField("IDACR", "IDACR", JdeDataType.Numeric),
        new JdeField("IDDDJ", "IDDDJ", JdeDataType.Numeric),
        new JdeField("IDACIS", "IDACIS", JdeDataType.String, 4),
        new JdeField("IDDL01", "IDDL01", JdeDataType.String, 60),
        new JdeField("IDDL02", "IDDL02", JdeDataType.String, 60),
        new JdeField("IDURRF", "IDURRF", JdeDataType.String, 30),
        new JdeField("IDURCD", "IDURCD", JdeDataType.String, 4),
        new JdeField("IDURDT", "IDURDT", JdeDataType.Numeric),
        new JdeField("IDURAT", "IDURAT", JdeDataType.Numeric),
        new JdeField("IDURAB", "IDURAB", JdeDataType.Numeric),
        new JdeField("IDCTID", "IDCTID", JdeDataType.String, 30),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDUPMT", "IDUPMT", JdeDataType.Numeric),
        new JdeField("IDADGI1", "IDADGI1", JdeDataType.String, 20),
        new JdeField("IDACEM1", "IDACEM1", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A22P_0", "Primary Key on IDKCO, IDDCT, IDDOC, IDPNO", new[] { "IDKCO", "IDDCT", "IDDOC", "IDPNO" }, isUnique: true, isPrimaryKey: true)
    };
}
