using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47128 - .
/// </summary>
public class F47128 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MKEDTY.
        /// </summary>
        public const string MKEDTY = "MKEDTY";

        /// <summary>
        /// MKEDSQ.
        /// </summary>
        public const string MKEDSQ = "MKEDSQ";

        /// <summary>
        /// MKEKCO.
        /// </summary>
        public const string MKEKCO = "MKEKCO";

        /// <summary>
        /// MKEDOC.
        /// </summary>
        public const string MKEDOC = "MKEDOC";

        /// <summary>
        /// MKEDCT.
        /// </summary>
        public const string MKEDCT = "MKEDCT";

        /// <summary>
        /// MKEDLN.
        /// </summary>
        public const string MKEDLN = "MKEDLN";

        /// <summary>
        /// MKEDSP.
        /// </summary>
        public const string MKEDSP = "MKEDSP";

        /// <summary>
        /// MKEDBT.
        /// </summary>
        public const string MKEDBT = "MKEDBT";

        /// <summary>
        /// MKUITM.
        /// </summary>
        public const string MKUITM = "MKUITM";

        /// <summary>
        /// MKSEQN.
        /// </summary>
        public const string MKSEQN = "MKSEQN";

        /// <summary>
        /// MKTRUM.
        /// </summary>
        public const string MKTRUM = "MKTRUM";

        /// <summary>
        /// MKTB01.
        /// </summary>
        public const string MKTB01 = "MKTB01";

        /// <summary>
        /// MKTB02.
        /// </summary>
        public const string MKTB02 = "MKTB02";

        /// <summary>
        /// MKTB03.
        /// </summary>
        public const string MKTB03 = "MKTB03";

        /// <summary>
        /// MKTB04.
        /// </summary>
        public const string MKTB04 = "MKTB04";

        /// <summary>
        /// MKTB05.
        /// </summary>
        public const string MKTB05 = "MKTB05";

        /// <summary>
        /// MKTB06.
        /// </summary>
        public const string MKTB06 = "MKTB06";

        /// <summary>
        /// MKTB07.
        /// </summary>
        public const string MKTB07 = "MKTB07";

        /// <summary>
        /// MKTB08.
        /// </summary>
        public const string MKTB08 = "MKTB08";

        /// <summary>
        /// MKTB09.
        /// </summary>
        public const string MKTB09 = "MKTB09";

        /// <summary>
        /// MKTB10.
        /// </summary>
        public const string MKTB10 = "MKTB10";

        /// <summary>
        /// MKWL01.
        /// </summary>
        public const string MKWL01 = "MKWL01";

        /// <summary>
        /// MKWL02.
        /// </summary>
        public const string MKWL02 = "MKWL02";

        /// <summary>
        /// MKWL03.
        /// </summary>
        public const string MKWL03 = "MKWL03";

        /// <summary>
        /// MKWL04.
        /// </summary>
        public const string MKWL04 = "MKWL04";

        /// <summary>
        /// MKWL05.
        /// </summary>
        public const string MKWL05 = "MKWL05";

        /// <summary>
        /// MKWL06.
        /// </summary>
        public const string MKWL06 = "MKWL06";

        /// <summary>
        /// MKWL07.
        /// </summary>
        public const string MKWL07 = "MKWL07";

        /// <summary>
        /// MKWL08.
        /// </summary>
        public const string MKWL08 = "MKWL08";

        /// <summary>
        /// MKWL09.
        /// </summary>
        public const string MKWL09 = "MKWL09";

        /// <summary>
        /// MKWL10.
        /// </summary>
        public const string MKWL10 = "MKWL10";

        /// <summary>
        /// MKLU01.
        /// </summary>
        public const string MKLU01 = "MKLU01";

        /// <summary>
        /// MKLU02.
        /// </summary>
        public const string MKLU02 = "MKLU02";

        /// <summary>
        /// MKLU03.
        /// </summary>
        public const string MKLU03 = "MKLU03";

        /// <summary>
        /// MKLU04.
        /// </summary>
        public const string MKLU04 = "MKLU04";

        /// <summary>
        /// MKLU05.
        /// </summary>
        public const string MKLU05 = "MKLU05";

        /// <summary>
        /// MKLU06.
        /// </summary>
        public const string MKLU06 = "MKLU06";

        /// <summary>
        /// MKLU07.
        /// </summary>
        public const string MKLU07 = "MKLU07";

        /// <summary>
        /// MKLU08.
        /// </summary>
        public const string MKLU08 = "MKLU08";

        /// <summary>
        /// MKLU09.
        /// </summary>
        public const string MKLU09 = "MKLU09";

        /// <summary>
        /// MKLU10.
        /// </summary>
        public const string MKLU10 = "MKLU10";

        /// <summary>
        /// MKQT01.
        /// </summary>
        public const string MKQT01 = "MKQT01";

        /// <summary>
        /// MKQT02.
        /// </summary>
        public const string MKQT02 = "MKQT02";

        /// <summary>
        /// MKQT03.
        /// </summary>
        public const string MKQT03 = "MKQT03";

        /// <summary>
        /// MKQT04.
        /// </summary>
        public const string MKQT04 = "MKQT04";

        /// <summary>
        /// MKQT05.
        /// </summary>
        public const string MKQT05 = "MKQT05";

        /// <summary>
        /// MKQT06.
        /// </summary>
        public const string MKQT06 = "MKQT06";

        /// <summary>
        /// MKQT07.
        /// </summary>
        public const string MKQT07 = "MKQT07";

        /// <summary>
        /// MKQT08.
        /// </summary>
        public const string MKQT08 = "MKQT08";

        /// <summary>
        /// MKQT09.
        /// </summary>
        public const string MKQT09 = "MKQT09";

        /// <summary>
        /// MKQT10.
        /// </summary>
        public const string MKQT10 = "MKQT10";

        /// <summary>
        /// MKTORG.
        /// </summary>
        public const string MKTORG = "MKTORG";

        /// <summary>
        /// MKUSER.
        /// </summary>
        public const string MKUSER = "MKUSER";

        /// <summary>
        /// MKPID.
        /// </summary>
        public const string MKPID = "MKPID";

        /// <summary>
        /// MKJOBN.
        /// </summary>
        public const string MKJOBN = "MKJOBN";

        /// <summary>
        /// MKUPMJ.
        /// </summary>
        public const string MKUPMJ = "MKUPMJ";

        /// <summary>
        /// MKTDAY.
        /// </summary>
        public const string MKTDAY = "MKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47128";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MKEDTY", "MKEDTY", JdeDataType.String, 2),
        new JdeField("MKEDSQ", "MKEDSQ", JdeDataType.Numeric),
        new JdeField("MKEKCO", "MKEKCO", JdeDataType.String, 10, true, true),
        new JdeField("MKEDOC", "MKEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MKEDCT", "MKEDCT", JdeDataType.String, 4, true, true),
        new JdeField("MKEDLN", "MKEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("MKEDSP", "MKEDSP", JdeDataType.String, 2),
        new JdeField("MKEDBT", "MKEDBT", JdeDataType.String, 30),
        new JdeField("MKUITM", "MKUITM", JdeDataType.String, 52, true, true),
        new JdeField("MKSEQN", "MKSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("MKTRUM", "MKTRUM", JdeDataType.String, 4),
        new JdeField("MKTB01", "MKTB01", JdeDataType.String, 24),
        new JdeField("MKTB02", "MKTB02", JdeDataType.String, 24),
        new JdeField("MKTB03", "MKTB03", JdeDataType.String, 24),
        new JdeField("MKTB04", "MKTB04", JdeDataType.String, 24),
        new JdeField("MKTB05", "MKTB05", JdeDataType.String, 24),
        new JdeField("MKTB06", "MKTB06", JdeDataType.String, 24),
        new JdeField("MKTB07", "MKTB07", JdeDataType.String, 24),
        new JdeField("MKTB08", "MKTB08", JdeDataType.String, 24),
        new JdeField("MKTB09", "MKTB09", JdeDataType.String, 24),
        new JdeField("MKTB10", "MKTB10", JdeDataType.String, 24),
        new JdeField("MKWL01", "MKWL01", JdeDataType.String, 40),
        new JdeField("MKWL02", "MKWL02", JdeDataType.String, 40),
        new JdeField("MKWL03", "MKWL03", JdeDataType.String, 40),
        new JdeField("MKWL04", "MKWL04", JdeDataType.String, 40),
        new JdeField("MKWL05", "MKWL05", JdeDataType.String, 40),
        new JdeField("MKWL06", "MKWL06", JdeDataType.String, 40),
        new JdeField("MKWL07", "MKWL07", JdeDataType.String, 40),
        new JdeField("MKWL08", "MKWL08", JdeDataType.String, 40),
        new JdeField("MKWL09", "MKWL09", JdeDataType.String, 40),
        new JdeField("MKWL10", "MKWL10", JdeDataType.String, 40),
        new JdeField("MKLU01", "MKLU01", JdeDataType.String, 60),
        new JdeField("MKLU02", "MKLU02", JdeDataType.String, 60),
        new JdeField("MKLU03", "MKLU03", JdeDataType.String, 60),
        new JdeField("MKLU04", "MKLU04", JdeDataType.String, 60),
        new JdeField("MKLU05", "MKLU05", JdeDataType.String, 60),
        new JdeField("MKLU06", "MKLU06", JdeDataType.String, 60),
        new JdeField("MKLU07", "MKLU07", JdeDataType.String, 60),
        new JdeField("MKLU08", "MKLU08", JdeDataType.String, 60),
        new JdeField("MKLU09", "MKLU09", JdeDataType.String, 60),
        new JdeField("MKLU10", "MKLU10", JdeDataType.String, 60),
        new JdeField("MKQT01", "MKQT01", JdeDataType.Numeric),
        new JdeField("MKQT02", "MKQT02", JdeDataType.Numeric),
        new JdeField("MKQT03", "MKQT03", JdeDataType.Numeric),
        new JdeField("MKQT04", "MKQT04", JdeDataType.Numeric),
        new JdeField("MKQT05", "MKQT05", JdeDataType.Numeric),
        new JdeField("MKQT06", "MKQT06", JdeDataType.Numeric),
        new JdeField("MKQT07", "MKQT07", JdeDataType.Numeric),
        new JdeField("MKQT08", "MKQT08", JdeDataType.Numeric),
        new JdeField("MKQT09", "MKQT09", JdeDataType.Numeric),
        new JdeField("MKQT10", "MKQT10", JdeDataType.Numeric),
        new JdeField("MKTORG", "MKTORG", JdeDataType.String, 20),
        new JdeField("MKUSER", "MKUSER", JdeDataType.String, 20),
        new JdeField("MKPID", "MKPID", JdeDataType.String, 20),
        new JdeField("MKJOBN", "MKJOBN", JdeDataType.String, 20),
        new JdeField("MKUPMJ", "MKUPMJ", JdeDataType.Numeric),
        new JdeField("MKTDAY", "MKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47128_0", "Primary Key on MKEDOC, MKEDCT, MKEKCO, MKEDLN, MKUITM, MKSEQN", new[] { "MKEDOC", "MKEDCT", "MKEKCO", "MKEDLN", "MKUITM", "MKSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
