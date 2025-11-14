using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1542 - .
/// </summary>
public class F1542 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OJDOCO.
        /// </summary>
        public const string OJDOCO = "OJDOCO";

        /// <summary>
        /// OJMCU.
        /// </summary>
        public const string OJMCU = "OJMCU";

        /// <summary>
        /// OJUNIT.
        /// </summary>
        public const string OJUNIT = "OJUNIT";

        /// <summary>
        /// OJDBAN.
        /// </summary>
        public const string OJDBAN = "OJDBAN";

        /// <summary>
        /// OJULI.
        /// </summary>
        public const string OJULI = "OJULI";

        /// <summary>
        /// OJPRDC.
        /// </summary>
        public const string OJPRDC = "OJPRDC";

        /// <summary>
        /// OJSTNR.
        /// </summary>
        public const string OJSTNR = "OJSTNR";

        /// <summary>
        /// OJCTRY.
        /// </summary>
        public const string OJCTRY = "OJCTRY";

        /// <summary>
        /// OJYR.
        /// </summary>
        public const string OJYR = "OJYR";

        /// <summary>
        /// OJAN8.
        /// </summary>
        public const string OJAN8 = "OJAN8";

        /// <summary>
        /// OJCO.
        /// </summary>
        public const string OJCO = "OJCO";

        /// <summary>
        /// OJMCUS.
        /// </summary>
        public const string OJMCUS = "OJMCUS";

        /// <summary>
        /// OJULI2.
        /// </summary>
        public const string OJULI2 = "OJULI2";

        /// <summary>
        /// OJRM11.
        /// </summary>
        public const string OJRM11 = "OJRM11";

        /// <summary>
        /// OJRM12.
        /// </summary>
        public const string OJRM12 = "OJRM12";

        /// <summary>
        /// OJRM13.
        /// </summary>
        public const string OJRM13 = "OJRM13";

        /// <summary>
        /// OJRM14.
        /// </summary>
        public const string OJRM14 = "OJRM14";

        /// <summary>
        /// OJRM15.
        /// </summary>
        public const string OJRM15 = "OJRM15";

        /// <summary>
        /// OJRM21.
        /// </summary>
        public const string OJRM21 = "OJRM21";

        /// <summary>
        /// OJRM22.
        /// </summary>
        public const string OJRM22 = "OJRM22";

        /// <summary>
        /// OJRM23.
        /// </summary>
        public const string OJRM23 = "OJRM23";

        /// <summary>
        /// OJRM24.
        /// </summary>
        public const string OJRM24 = "OJRM24";

        /// <summary>
        /// OJRM25.
        /// </summary>
        public const string OJRM25 = "OJRM25";

        /// <summary>
        /// OJURCD.
        /// </summary>
        public const string OJURCD = "OJURCD";

        /// <summary>
        /// OJURDT.
        /// </summary>
        public const string OJURDT = "OJURDT";

        /// <summary>
        /// OJURAT.
        /// </summary>
        public const string OJURAT = "OJURAT";

        /// <summary>
        /// OJURRF.
        /// </summary>
        public const string OJURRF = "OJURRF";

        /// <summary>
        /// OJES01.
        /// </summary>
        public const string OJES01 = "OJES01";

        /// <summary>
        /// OJES02.
        /// </summary>
        public const string OJES02 = "OJES02";

        /// <summary>
        /// OJES03.
        /// </summary>
        public const string OJES03 = "OJES03";

        /// <summary>
        /// OJES04.
        /// </summary>
        public const string OJES04 = "OJES04";

        /// <summary>
        /// OJES05.
        /// </summary>
        public const string OJES05 = "OJES05";

        /// <summary>
        /// OJES06.
        /// </summary>
        public const string OJES06 = "OJES06";

        /// <summary>
        /// OJES07.
        /// </summary>
        public const string OJES07 = "OJES07";

        /// <summary>
        /// OJES08.
        /// </summary>
        public const string OJES08 = "OJES08";

        /// <summary>
        /// OJES09.
        /// </summary>
        public const string OJES09 = "OJES09";

        /// <summary>
        /// OJES10.
        /// </summary>
        public const string OJES10 = "OJES10";

        /// <summary>
        /// OJES11.
        /// </summary>
        public const string OJES11 = "OJES11";

        /// <summary>
        /// OJES12.
        /// </summary>
        public const string OJES12 = "OJES12";

        /// <summary>
        /// OJCMFG.
        /// </summary>
        public const string OJCMFG = "OJCMFG";

        /// <summary>
        /// OJCRCD.
        /// </summary>
        public const string OJCRCD = "OJCRCD";

        /// <summary>
        /// OJBCRC.
        /// </summary>
        public const string OJBCRC = "OJBCRC";

        /// <summary>
        /// OJCRRM.
        /// </summary>
        public const string OJCRRM = "OJCRRM";

        /// <summary>
        /// OJCRR.
        /// </summary>
        public const string OJCRR = "OJCRR";

        /// <summary>
        /// OJUSER.
        /// </summary>
        public const string OJUSER = "OJUSER";

        /// <summary>
        /// OJPID.
        /// </summary>
        public const string OJPID = "OJPID";

        /// <summary>
        /// OJJOBN.
        /// </summary>
        public const string OJJOBN = "OJJOBN";

        /// <summary>
        /// OJUPMJ.
        /// </summary>
        public const string OJUPMJ = "OJUPMJ";

        /// <summary>
        /// OJUPMT.
        /// </summary>
        public const string OJUPMT = "OJUPMT";

        /// <summary>
        /// OJTORG.
        /// </summary>
        public const string OJTORG = "OJTORG";

        /// <summary>
        /// OJENTJ.
        /// </summary>
        public const string OJENTJ = "OJENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1542";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OJDOCO", "OJDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OJMCU", "OJMCU", JdeDataType.String, 24, true, true),
        new JdeField("OJUNIT", "OJUNIT", JdeDataType.String, 16, true, true),
        new JdeField("OJDBAN", "OJDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("OJULI", "OJULI", JdeDataType.String, 16, true, true),
        new JdeField("OJPRDC", "OJPRDC", JdeDataType.String, 8, true, true),
        new JdeField("OJSTNR", "OJSTNR", JdeDataType.String, 20, true, true),
        new JdeField("OJCTRY", "OJCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OJYR", "OJYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OJAN8", "OJAN8", JdeDataType.Numeric),
        new JdeField("OJCO", "OJCO", JdeDataType.String, 10),
        new JdeField("OJMCUS", "OJMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OJULI2", "OJULI2", JdeDataType.String, 16),
        new JdeField("OJRM11", "OJRM11", JdeDataType.String, 8),
        new JdeField("OJRM12", "OJRM12", JdeDataType.String, 8),
        new JdeField("OJRM13", "OJRM13", JdeDataType.String, 8),
        new JdeField("OJRM14", "OJRM14", JdeDataType.String, 8),
        new JdeField("OJRM15", "OJRM15", JdeDataType.String, 8),
        new JdeField("OJRM21", "OJRM21", JdeDataType.String, 8),
        new JdeField("OJRM22", "OJRM22", JdeDataType.String, 8),
        new JdeField("OJRM23", "OJRM23", JdeDataType.String, 8),
        new JdeField("OJRM24", "OJRM24", JdeDataType.String, 8),
        new JdeField("OJRM25", "OJRM25", JdeDataType.String, 8),
        new JdeField("OJURCD", "OJURCD", JdeDataType.String, 4),
        new JdeField("OJURDT", "OJURDT", JdeDataType.Numeric),
        new JdeField("OJURAT", "OJURAT", JdeDataType.Numeric),
        new JdeField("OJURRF", "OJURRF", JdeDataType.String, 30),
        new JdeField("OJES01", "OJES01", JdeDataType.Numeric),
        new JdeField("OJES02", "OJES02", JdeDataType.Numeric),
        new JdeField("OJES03", "OJES03", JdeDataType.Numeric),
        new JdeField("OJES04", "OJES04", JdeDataType.Numeric),
        new JdeField("OJES05", "OJES05", JdeDataType.Numeric),
        new JdeField("OJES06", "OJES06", JdeDataType.Numeric),
        new JdeField("OJES07", "OJES07", JdeDataType.Numeric),
        new JdeField("OJES08", "OJES08", JdeDataType.Numeric),
        new JdeField("OJES09", "OJES09", JdeDataType.Numeric),
        new JdeField("OJES10", "OJES10", JdeDataType.Numeric),
        new JdeField("OJES11", "OJES11", JdeDataType.Numeric),
        new JdeField("OJES12", "OJES12", JdeDataType.Numeric),
        new JdeField("OJCMFG", "OJCMFG", JdeDataType.String, 2),
        new JdeField("OJCRCD", "OJCRCD", JdeDataType.String, 6),
        new JdeField("OJBCRC", "OJBCRC", JdeDataType.String, 6),
        new JdeField("OJCRRM", "OJCRRM", JdeDataType.String, 2),
        new JdeField("OJCRR", "OJCRR", JdeDataType.Numeric),
        new JdeField("OJUSER", "OJUSER", JdeDataType.String, 20),
        new JdeField("OJPID", "OJPID", JdeDataType.String, 20),
        new JdeField("OJJOBN", "OJJOBN", JdeDataType.String, 20),
        new JdeField("OJUPMJ", "OJUPMJ", JdeDataType.Numeric),
        new JdeField("OJUPMT", "OJUPMT", JdeDataType.Numeric),
        new JdeField("OJTORG", "OJTORG", JdeDataType.String, 20),
        new JdeField("OJENTJ", "OJENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1542_0", "Primary Key on OJMCUS, OJDOCO, OJMCU, OJUNIT, OJDBAN, OJULI, OJPRDC, OJSTNR, OJCTRY, OJYR", new[] { "OJMCUS", "OJDOCO", "OJMCU", "OJUNIT", "OJDBAN", "OJULI", "OJPRDC", "OJSTNR", "OJCTRY", "OJYR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1542_2", "Index on OJDOCO, OJMCU, OJUNIT, OJDBAN, OJULI, OJPRDC, OJSTNR, OJCTRY, OJYR", new[] { "OJDOCO", "OJMCU", "OJUNIT", "OJDBAN", "OJULI", "OJPRDC", "OJSTNR", "OJCTRY", "OJYR" })
    };
}
