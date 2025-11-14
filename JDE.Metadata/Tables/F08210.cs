using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08210 - .
/// </summary>
public class F08210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ANAIRI.
        /// </summary>
        public const string ANAIRI = "ANAIRI";

        /// <summary>
        /// ANRPYR.
        /// </summary>
        public const string ANRPYR = "ANRPYR";

        /// <summary>
        /// ANAIRD.
        /// </summary>
        public const string ANAIRD = "ANAIRD";

        /// <summary>
        /// ANBOTT.
        /// </summary>
        public const string ANBOTT = "ANBOTT";

        /// <summary>
        /// ANAIRC.
        /// </summary>
        public const string ANAIRC = "ANAIRC";

        /// <summary>
        /// ANAG01.
        /// </summary>
        public const string ANAG01 = "ANAG01";

        /// <summary>
        /// ANAG02.
        /// </summary>
        public const string ANAG02 = "ANAG02";

        /// <summary>
        /// ANAG03.
        /// </summary>
        public const string ANAG03 = "ANAG03";

        /// <summary>
        /// ANACAVER01.
        /// </summary>
        public const string ANACAVER01 = "ANACAVER01";

        /// <summary>
        /// ANACAVER02.
        /// </summary>
        public const string ANACAVER02 = "ANACAVER02";

        /// <summary>
        /// ANAG04.
        /// </summary>
        public const string ANAG04 = "ANAG04";

        /// <summary>
        /// ANACAVER03.
        /// </summary>
        public const string ANACAVER03 = "ANACAVER03";

        /// <summary>
        /// ANAG05.
        /// </summary>
        public const string ANAG05 = "ANAG05";

        /// <summary>
        /// ANAG06.
        /// </summary>
        public const string ANAG06 = "ANAG06";

        /// <summary>
        /// ANACAVER04.
        /// </summary>
        public const string ANACAVER04 = "ANACAVER04";

        /// <summary>
        /// ANAG07.
        /// </summary>
        public const string ANAG07 = "ANAG07";

        /// <summary>
        /// ANAG13.
        /// </summary>
        public const string ANAG13 = "ANAG13";

        /// <summary>
        /// ANACAVER05.
        /// </summary>
        public const string ANACAVER05 = "ANACAVER05";

        /// <summary>
        /// ANACAVER06.
        /// </summary>
        public const string ANACAVER06 = "ANACAVER06";

        /// <summary>
        /// ANACAVER07.
        /// </summary>
        public const string ANACAVER07 = "ANACAVER07";

        /// <summary>
        /// ANACAVER08.
        /// </summary>
        public const string ANACAVER08 = "ANACAVER08";

        /// <summary>
        /// ANACAVER09.
        /// </summary>
        public const string ANACAVER09 = "ANACAVER09";

        /// <summary>
        /// ANACAVER10.
        /// </summary>
        public const string ANACAVER10 = "ANACAVER10";

        /// <summary>
        /// ANSPASUSL1.
        /// </summary>
        public const string ANSPASUSL1 = "ANSPASUSL1";

        /// <summary>
        /// ANSPASUSL2.
        /// </summary>
        public const string ANSPASUSL2 = "ANSPASUSL2";

        /// <summary>
        /// ANSPASUSL3.
        /// </summary>
        public const string ANSPASUSL3 = "ANSPASUSL3";

        /// <summary>
        /// ANSPASUSL4.
        /// </summary>
        public const string ANSPASUSL4 = "ANSPASUSL4";

        /// <summary>
        /// ANSPASUSL5.
        /// </summary>
        public const string ANSPASUSL5 = "ANSPASUSL5";

        /// <summary>
        /// ANSPASUSL6.
        /// </summary>
        public const string ANSPASUSL6 = "ANSPASUSL6";

        /// <summary>
        /// ANSPASUSL7.
        /// </summary>
        public const string ANSPASUSL7 = "ANSPASUSL7";

        /// <summary>
        /// ANSPASUSL8.
        /// </summary>
        public const string ANSPASUSL8 = "ANSPASUSL8";

        /// <summary>
        /// ANSPANUSL1.
        /// </summary>
        public const string ANSPANUSL1 = "ANSPANUSL1";

        /// <summary>
        /// ANSPANUSL2.
        /// </summary>
        public const string ANSPANUSL2 = "ANSPANUSL2";

        /// <summary>
        /// ANSPANUSL3.
        /// </summary>
        public const string ANSPANUSL3 = "ANSPANUSL3";

        /// <summary>
        /// ANSPANUSL4.
        /// </summary>
        public const string ANSPANUSL4 = "ANSPANUSL4";

        /// <summary>
        /// ANSPADUSL1.
        /// </summary>
        public const string ANSPADUSL1 = "ANSPADUSL1";

        /// <summary>
        /// ANSPADUSL2.
        /// </summary>
        public const string ANSPADUSL2 = "ANSPADUSL2";

        /// <summary>
        /// ANSPADUSL3.
        /// </summary>
        public const string ANSPADUSL3 = "ANSPADUSL3";

        /// <summary>
        /// ANSPADUSL4.
        /// </summary>
        public const string ANSPADUSL4 = "ANSPADUSL4";

        /// <summary>
        /// ANSPACUSL1.
        /// </summary>
        public const string ANSPACUSL1 = "ANSPACUSL1";

        /// <summary>
        /// ANSPACUSL2.
        /// </summary>
        public const string ANSPACUSL2 = "ANSPACUSL2";

        /// <summary>
        /// ANSPACUSL3.
        /// </summary>
        public const string ANSPACUSL3 = "ANSPACUSL3";

        /// <summary>
        /// ANSPACUSL4.
        /// </summary>
        public const string ANSPACUSL4 = "ANSPACUSL4";

        /// <summary>
        /// ANUSER.
        /// </summary>
        public const string ANUSER = "ANUSER";

        /// <summary>
        /// ANPID.
        /// </summary>
        public const string ANPID = "ANPID";

        /// <summary>
        /// ANJOBN.
        /// </summary>
        public const string ANJOBN = "ANJOBN";

        /// <summary>
        /// ANUPMJ.
        /// </summary>
        public const string ANUPMJ = "ANUPMJ";

        /// <summary>
        /// ANUPMT.
        /// </summary>
        public const string ANUPMT = "ANUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ANAIRI", "ANAIRI", JdeDataType.String, 20, true, true),
        new JdeField("ANRPYR", "ANRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("ANAIRD", "ANAIRD", JdeDataType.String, 60),
        new JdeField("ANBOTT", "ANBOTT", JdeDataType.String, 2),
        new JdeField("ANAIRC", "ANAIRC", JdeDataType.String, 20),
        new JdeField("ANAG01", "ANAG01", JdeDataType.String, 2),
        new JdeField("ANAG02", "ANAG02", JdeDataType.String, 2),
        new JdeField("ANAG03", "ANAG03", JdeDataType.String, 2),
        new JdeField("ANACAVER01", "ANACAVER01", JdeDataType.String, 20),
        new JdeField("ANACAVER02", "ANACAVER02", JdeDataType.String, 20),
        new JdeField("ANAG04", "ANAG04", JdeDataType.String, 2),
        new JdeField("ANACAVER03", "ANACAVER03", JdeDataType.String, 20),
        new JdeField("ANAG05", "ANAG05", JdeDataType.String, 2),
        new JdeField("ANAG06", "ANAG06", JdeDataType.Numeric),
        new JdeField("ANACAVER04", "ANACAVER04", JdeDataType.String, 20),
        new JdeField("ANAG07", "ANAG07", JdeDataType.String, 2),
        new JdeField("ANAG13", "ANAG13", JdeDataType.Numeric),
        new JdeField("ANACAVER05", "ANACAVER05", JdeDataType.String, 20),
        new JdeField("ANACAVER06", "ANACAVER06", JdeDataType.String, 20),
        new JdeField("ANACAVER07", "ANACAVER07", JdeDataType.String, 20),
        new JdeField("ANACAVER08", "ANACAVER08", JdeDataType.String, 20),
        new JdeField("ANACAVER09", "ANACAVER09", JdeDataType.String, 20),
        new JdeField("ANACAVER10", "ANACAVER10", JdeDataType.String, 20),
        new JdeField("ANSPASUSL1", "ANSPASUSL1", JdeDataType.String, 60),
        new JdeField("ANSPASUSL2", "ANSPASUSL2", JdeDataType.String, 60),
        new JdeField("ANSPASUSL3", "ANSPASUSL3", JdeDataType.String, 60),
        new JdeField("ANSPASUSL4", "ANSPASUSL4", JdeDataType.String, 60),
        new JdeField("ANSPASUSL5", "ANSPASUSL5", JdeDataType.String, 20),
        new JdeField("ANSPASUSL6", "ANSPASUSL6", JdeDataType.String, 20),
        new JdeField("ANSPASUSL7", "ANSPASUSL7", JdeDataType.String, 20),
        new JdeField("ANSPASUSL8", "ANSPASUSL8", JdeDataType.String, 20),
        new JdeField("ANSPANUSL1", "ANSPANUSL1", JdeDataType.Numeric),
        new JdeField("ANSPANUSL2", "ANSPANUSL2", JdeDataType.Numeric),
        new JdeField("ANSPANUSL3", "ANSPANUSL3", JdeDataType.Numeric),
        new JdeField("ANSPANUSL4", "ANSPANUSL4", JdeDataType.Numeric),
        new JdeField("ANSPADUSL1", "ANSPADUSL1", JdeDataType.Numeric),
        new JdeField("ANSPADUSL2", "ANSPADUSL2", JdeDataType.Numeric),
        new JdeField("ANSPADUSL3", "ANSPADUSL3", JdeDataType.Numeric),
        new JdeField("ANSPADUSL4", "ANSPADUSL4", JdeDataType.Numeric),
        new JdeField("ANSPACUSL1", "ANSPACUSL1", JdeDataType.String, 2),
        new JdeField("ANSPACUSL2", "ANSPACUSL2", JdeDataType.String, 2),
        new JdeField("ANSPACUSL3", "ANSPACUSL3", JdeDataType.String, 2),
        new JdeField("ANSPACUSL4", "ANSPACUSL4", JdeDataType.String, 2),
        new JdeField("ANUSER", "ANUSER", JdeDataType.String, 20),
        new JdeField("ANPID", "ANPID", JdeDataType.String, 20),
        new JdeField("ANJOBN", "ANJOBN", JdeDataType.String, 20),
        new JdeField("ANUPMJ", "ANUPMJ", JdeDataType.Numeric),
        new JdeField("ANUPMT", "ANUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08210_0", "Primary Key on ANAIRI, ANRPYR", new[] { "ANAIRI", "ANRPYR" }, isUnique: true, isPrimaryKey: true)
    };
}
