using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B38 - .
/// </summary>
public class F31B38 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VRVARID.
        /// </summary>
        public const string VRVARID = "VRVARID";

        /// <summary>
        /// VRVARCODE.
        /// </summary>
        public const string VRVARCODE = "VRVARCODE";

        /// <summary>
        /// VRVARLNAME.
        /// </summary>
        public const string VRVARLNAME = "VRVARLNAME";

        /// <summary>
        /// VRVARAUTH.
        /// </summary>
        public const string VRVARAUTH = "VRVARAUTH";

        /// <summary>
        /// VRVARFAM.
        /// </summary>
        public const string VRVARFAM = "VRVARFAM";

        /// <summary>
        /// VRVARFRDTE.
        /// </summary>
        public const string VRVARFRDTE = "VRVARFRDTE";

        /// <summary>
        /// VRVARTODTE.
        /// </summary>
        public const string VRVARTODTE = "VRVARTODTE";

        /// <summary>
        /// VRSORDNO.
        /// </summary>
        public const string VRSORDNO = "VRSORDNO";

        /// <summary>
        /// VRSCODE.
        /// </summary>
        public const string VRSCODE = "VRSCODE";

        /// <summary>
        /// VRVARCOLOR.
        /// </summary>
        public const string VRVARCOLOR = "VRVARCOLOR";

        /// <summary>
        /// VRVARCOMM.
        /// </summary>
        public const string VRVARCOMM = "VRVARCOMM";

        /// <summary>
        /// VRUSER.
        /// </summary>
        public const string VRUSER = "VRUSER";

        /// <summary>
        /// VRPID.
        /// </summary>
        public const string VRPID = "VRPID";

        /// <summary>
        /// VRJOBN.
        /// </summary>
        public const string VRJOBN = "VRJOBN";

        /// <summary>
        /// VRUPMJ.
        /// </summary>
        public const string VRUPMJ = "VRUPMJ";

        /// <summary>
        /// VRUPMT.
        /// </summary>
        public const string VRUPMT = "VRUPMT";

        /// <summary>
        /// VRURCD.
        /// </summary>
        public const string VRURCD = "VRURCD";

        /// <summary>
        /// VRURDT.
        /// </summary>
        public const string VRURDT = "VRURDT";

        /// <summary>
        /// VRURAT.
        /// </summary>
        public const string VRURAT = "VRURAT";

        /// <summary>
        /// VRURRF.
        /// </summary>
        public const string VRURRF = "VRURRF";

        /// <summary>
        /// VRURAB.
        /// </summary>
        public const string VRURAB = "VRURAB";

        /// <summary>
        /// VRVRCC01.
        /// </summary>
        public const string VRVRCC01 = "VRVRCC01";

        /// <summary>
        /// VRVRCC02.
        /// </summary>
        public const string VRVRCC02 = "VRVRCC02";
    }

    /// <inheritdoc />
    public override string TableName => "F31B38";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VRVARID", "VRVARID", JdeDataType.Numeric, null, true, true),
        new JdeField("VRVARCODE", "VRVARCODE", JdeDataType.String, 10),
        new JdeField("VRVARLNAME", "VRVARLNAME", JdeDataType.String, 60),
        new JdeField("VRVARAUTH", "VRVARAUTH", JdeDataType.String, 10),
        new JdeField("VRVARFAM", "VRVARFAM", JdeDataType.String, 16),
        new JdeField("VRVARFRDTE", "VRVARFRDTE", JdeDataType.Numeric),
        new JdeField("VRVARTODTE", "VRVARTODTE", JdeDataType.Numeric),
        new JdeField("VRSORDNO", "VRSORDNO", JdeDataType.Numeric),
        new JdeField("VRSCODE", "VRSCODE", JdeDataType.String, 2),
        new JdeField("VRVARCOLOR", "VRVARCOLOR", JdeDataType.String, 2),
        new JdeField("VRVARCOMM", "VRVARCOMM", JdeDataType.String, 60),
        new JdeField("VRUSER", "VRUSER", JdeDataType.String, 20),
        new JdeField("VRPID", "VRPID", JdeDataType.String, 20),
        new JdeField("VRJOBN", "VRJOBN", JdeDataType.String, 20),
        new JdeField("VRUPMJ", "VRUPMJ", JdeDataType.Numeric),
        new JdeField("VRUPMT", "VRUPMT", JdeDataType.Numeric),
        new JdeField("VRURCD", "VRURCD", JdeDataType.String, 4),
        new JdeField("VRURDT", "VRURDT", JdeDataType.Numeric),
        new JdeField("VRURAT", "VRURAT", JdeDataType.Numeric),
        new JdeField("VRURRF", "VRURRF", JdeDataType.String, 30),
        new JdeField("VRURAB", "VRURAB", JdeDataType.Numeric),
        new JdeField("VRVRCC01", "VRVRCC01", JdeDataType.String, 6),
        new JdeField("VRVRCC02", "VRVRCC02", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B38_0", "Primary Key on VRVARID", new[] { "VRVARID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B38_2", "Index on VRVARCODE", new[] { "VRVARCODE" })
    };
}
