using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49003 - .
/// </summary>
public class F49003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTLDTY.
        /// </summary>
        public const string LTLDTY = "LTLDTY";

        /// <summary>
        /// LTDATY.
        /// </summary>
        public const string LTDATY = "LTDATY";

        /// <summary>
        /// LTLT01.
        /// </summary>
        public const string LTLT01 = "LTLT01";

        /// <summary>
        /// LTLT02.
        /// </summary>
        public const string LTLT02 = "LTLT02";

        /// <summary>
        /// LTLT03.
        /// </summary>
        public const string LTLT03 = "LTLT03";

        /// <summary>
        /// LTLT04.
        /// </summary>
        public const string LTLT04 = "LTLT04";

        /// <summary>
        /// LTLT05.
        /// </summary>
        public const string LTLT05 = "LTLT05";

        /// <summary>
        /// LTLT06.
        /// </summary>
        public const string LTLT06 = "LTLT06";

        /// <summary>
        /// LTLT07.
        /// </summary>
        public const string LTLT07 = "LTLT07";

        /// <summary>
        /// LTLT08.
        /// </summary>
        public const string LTLT08 = "LTLT08";

        /// <summary>
        /// LTLT09.
        /// </summary>
        public const string LTLT09 = "LTLT09";

        /// <summary>
        /// LTLT10.
        /// </summary>
        public const string LTLT10 = "LTLT10";

        /// <summary>
        /// LTLT11.
        /// </summary>
        public const string LTLT11 = "LTLT11";

        /// <summary>
        /// LTLT12.
        /// </summary>
        public const string LTLT12 = "LTLT12";

        /// <summary>
        /// LTLT13.
        /// </summary>
        public const string LTLT13 = "LTLT13";

        /// <summary>
        /// LTLT14.
        /// </summary>
        public const string LTLT14 = "LTLT14";

        /// <summary>
        /// LTLT15.
        /// </summary>
        public const string LTLT15 = "LTLT15";

        /// <summary>
        /// LTLT16.
        /// </summary>
        public const string LTLT16 = "LTLT16";

        /// <summary>
        /// LTURCD.
        /// </summary>
        public const string LTURCD = "LTURCD";

        /// <summary>
        /// LTURDT.
        /// </summary>
        public const string LTURDT = "LTURDT";

        /// <summary>
        /// LTURAT.
        /// </summary>
        public const string LTURAT = "LTURAT";

        /// <summary>
        /// LTURAB.
        /// </summary>
        public const string LTURAB = "LTURAB";

        /// <summary>
        /// LTURRF.
        /// </summary>
        public const string LTURRF = "LTURRF";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTTDAY.
        /// </summary>
        public const string LTTDAY = "LTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTLDTY", "LTLDTY", JdeDataType.String, 4, true, true),
        new JdeField("LTDATY", "LTDATY", JdeDataType.String, 2),
        new JdeField("LTLT01", "LTLT01", JdeDataType.String, 2),
        new JdeField("LTLT02", "LTLT02", JdeDataType.String, 2),
        new JdeField("LTLT03", "LTLT03", JdeDataType.String, 2),
        new JdeField("LTLT04", "LTLT04", JdeDataType.String, 2),
        new JdeField("LTLT05", "LTLT05", JdeDataType.String, 2),
        new JdeField("LTLT06", "LTLT06", JdeDataType.String, 2),
        new JdeField("LTLT07", "LTLT07", JdeDataType.String, 2),
        new JdeField("LTLT08", "LTLT08", JdeDataType.String, 2),
        new JdeField("LTLT09", "LTLT09", JdeDataType.String, 2),
        new JdeField("LTLT10", "LTLT10", JdeDataType.String, 2),
        new JdeField("LTLT11", "LTLT11", JdeDataType.String, 2),
        new JdeField("LTLT12", "LTLT12", JdeDataType.String, 2),
        new JdeField("LTLT13", "LTLT13", JdeDataType.String, 2),
        new JdeField("LTLT14", "LTLT14", JdeDataType.String, 2),
        new JdeField("LTLT15", "LTLT15", JdeDataType.String, 2),
        new JdeField("LTLT16", "LTLT16", JdeDataType.String, 2),
        new JdeField("LTURCD", "LTURCD", JdeDataType.String, 4),
        new JdeField("LTURDT", "LTURDT", JdeDataType.Numeric),
        new JdeField("LTURAT", "LTURAT", JdeDataType.Numeric),
        new JdeField("LTURAB", "LTURAB", JdeDataType.Numeric),
        new JdeField("LTURRF", "LTURRF", JdeDataType.String, 30),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTTDAY", "LTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49003_0", "Primary Key on LTLDTY", new[] { "LTLDTY" }, isUnique: true, isPrimaryKey: true)
    };
}
