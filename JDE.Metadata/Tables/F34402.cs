using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34402 - .
/// </summary>
public class F34402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTUKID.
        /// </summary>
        public const string PTUKID = "PTUKID";

        /// <summary>
        /// PTKCO.
        /// </summary>
        public const string PTKCO = "PTKCO";

        /// <summary>
        /// PTPRODT.
        /// </summary>
        public const string PTPRODT = "PTPRODT";

        /// <summary>
        /// PTSEGNM.
        /// </summary>
        public const string PTSEGNM = "PTSEGNM";

        /// <summary>
        /// PTSSQNO.
        /// </summary>
        public const string PTSSQNO = "PTSSQNO";

        /// <summary>
        /// PTESF.
        /// </summary>
        public const string PTESF = "PTESF";

        /// <summary>
        /// PTSPTV.
        /// </summary>
        public const string PTSPTV = "PTSPTV";

        /// <summary>
        /// PTFFU3.
        /// </summary>
        public const string PTFFU3 = "PTFFU3";

        /// <summary>
        /// PTFFU4.
        /// </summary>
        public const string PTFFU4 = "PTFFU4";

        /// <summary>
        /// PTTFUDJ.
        /// </summary>
        public const string PTTFUDJ = "PTTFUDJ";

        /// <summary>
        /// PTURCD.
        /// </summary>
        public const string PTURCD = "PTURCD";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTUKID", "PTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PTKCO", "PTKCO", JdeDataType.String, 10, true, true),
        new JdeField("PTPRODT", "PTPRODT", JdeDataType.String, 8, true, true),
        new JdeField("PTSEGNM", "PTSEGNM", JdeDataType.String, 60),
        new JdeField("PTSSQNO", "PTSSQNO", JdeDataType.Numeric),
        new JdeField("PTESF", "PTESF", JdeDataType.String, 2),
        new JdeField("PTSPTV", "PTSPTV", JdeDataType.String, 2),
        new JdeField("PTFFU3", "PTFFU3", JdeDataType.String, 20),
        new JdeField("PTFFU4", "PTFFU4", JdeDataType.Numeric),
        new JdeField("PTTFUDJ", "PTTFUDJ", JdeDataType.Numeric),
        new JdeField("PTURCD", "PTURCD", JdeDataType.String, 4),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34402_0", "Primary Key on PTUKID, PTKCO, PTPRODT", new[] { "PTUKID", "PTKCO", "PTPRODT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34402_2", "Index on PTKCO, PTPRODT", new[] { "PTKCO", "PTPRODT" })
    };
}
