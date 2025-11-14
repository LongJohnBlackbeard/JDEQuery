using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A210 - .
/// </summary>
public class F34A210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0ATPRN.
        /// </summary>
        public const string N0ATPRN = "N0ATPRN";

        /// <summary>
        /// N0ATPD.
        /// </summary>
        public const string N0ATPD = "N0ATPD";

        /// <summary>
        /// N0ATPFCF.
        /// </summary>
        public const string N0ATPFCF = "N0ATPFCF";

        /// <summary>
        /// N0ATPBCF.
        /// </summary>
        public const string N0ATPBCF = "N0ATPBCF";

        /// <summary>
        /// N0ATPAAF.
        /// </summary>
        public const string N0ATPAAF = "N0ATPAAF";

        /// <summary>
        /// N0ATPAW.
        /// </summary>
        public const string N0ATPAW = "N0ATPAW";

        /// <summary>
        /// N0ATPPDDCF.
        /// </summary>
        public const string N0ATPPDDCF = "N0ATPPDDCF";

        /// <summary>
        /// N0ATPPDSCF.
        /// </summary>
        public const string N0ATPPDSCF = "N0ATPPDSCF";

        /// <summary>
        /// N0ATPISFC.
        /// </summary>
        public const string N0ATPISFC = "N0ATPISFC";

        /// <summary>
        /// N0ATPISTF.
        /// </summary>
        public const string N0ATPISTF = "N0ATPISTF";

        /// <summary>
        /// N0ATPATFC.
        /// </summary>
        public const string N0ATPATFC = "N0ATPATFC";

        /// <summary>
        /// N0ATPATF.
        /// </summary>
        public const string N0ATPATF = "N0ATPATF";

        /// <summary>
        /// N0ATPDCAF.
        /// </summary>
        public const string N0ATPDCAF = "N0ATPDCAF";

        /// <summary>
        /// N0ATPISO.
        /// </summary>
        public const string N0ATPISO = "N0ATPISO";

        /// <summary>
        /// N0ATPIIO.
        /// </summary>
        public const string N0ATPIIO = "N0ATPIIO";

        /// <summary>
        /// N0ATPIDWD.
        /// </summary>
        public const string N0ATPIDWD = "N0ATPIDWD";

        /// <summary>
        /// N0ATPIRWD.
        /// </summary>
        public const string N0ATPIRWD = "N0ATPIRWD";

        /// <summary>
        /// N0ATPINWD.
        /// </summary>
        public const string N0ATPINWD = "N0ATPINWD";

        /// <summary>
        /// N0ATPIUDD.
        /// </summary>
        public const string N0ATPIUDD = "N0ATPIUDD";

        /// <summary>
        /// N0ATPIFSD.
        /// </summary>
        public const string N0ATPIFSD = "N0ATPIFSD";

        /// <summary>
        /// N0ATPIDM.
        /// </summary>
        public const string N0ATPIDM = "N0ATPIDM";

        /// <summary>
        /// N0ATPIRM.
        /// </summary>
        public const string N0ATPIRM = "N0ATPIRM";

        /// <summary>
        /// N0ATPIDWR.
        /// </summary>
        public const string N0ATPIDWR = "N0ATPIDWR";

        /// <summary>
        /// N0ATPIRWR.
        /// </summary>
        public const string N0ATPIRWR = "N0ATPIRWR";

        /// <summary>
        /// N0ATPINWR.
        /// </summary>
        public const string N0ATPINWR = "N0ATPINWR";

        /// <summary>
        /// N0ATPIUDS.
        /// </summary>
        public const string N0ATPIUDS = "N0ATPIUDS";

        /// <summary>
        /// N0ATPIIR.
        /// </summary>
        public const string N0ATPIIR = "N0ATPIIR";

        /// <summary>
        /// N0ATPISR.
        /// </summary>
        public const string N0ATPISR = "N0ATPISR";

        /// <summary>
        /// N0ATPIPO.
        /// </summary>
        public const string N0ATPIPO = "N0ATPIPO";

        /// <summary>
        /// N0ATPIOA.
        /// </summary>
        public const string N0ATPIOA = "N0ATPIOA";

        /// <summary>
        /// N0ATPIIT.
        /// </summary>
        public const string N0ATPIIT = "N0ATPIIT";

        /// <summary>
        /// N0ATPIFSR.
        /// </summary>
        public const string N0ATPIFSR = "N0ATPIFSR";

        /// <summary>
        /// N0URCD.
        /// </summary>
        public const string N0URCD = "N0URCD";

        /// <summary>
        /// N0URDT.
        /// </summary>
        public const string N0URDT = "N0URDT";

        /// <summary>
        /// N0URAT.
        /// </summary>
        public const string N0URAT = "N0URAT";

        /// <summary>
        /// N0URAB.
        /// </summary>
        public const string N0URAB = "N0URAB";

        /// <summary>
        /// N0URRF.
        /// </summary>
        public const string N0URRF = "N0URRF";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0JOBN.
        /// </summary>
        public const string N0JOBN = "N0JOBN";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0TDAY.
        /// </summary>
        public const string N0TDAY = "N0TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34A210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0ATPRN", "N0ATPRN", JdeDataType.String, 160, true, true),
        new JdeField("N0ATPD", "N0ATPD", JdeDataType.String, 160),
        new JdeField("N0ATPFCF", "N0ATPFCF", JdeDataType.String, 2),
        new JdeField("N0ATPBCF", "N0ATPBCF", JdeDataType.String, 2),
        new JdeField("N0ATPAAF", "N0ATPAAF", JdeDataType.String, 2),
        new JdeField("N0ATPAW", "N0ATPAW", JdeDataType.Numeric),
        new JdeField("N0ATPPDDCF", "N0ATPPDDCF", JdeDataType.Numeric),
        new JdeField("N0ATPPDSCF", "N0ATPPDSCF", JdeDataType.Numeric),
        new JdeField("N0ATPISFC", "N0ATPISFC", JdeDataType.String, 60),
        new JdeField("N0ATPISTF", "N0ATPISTF", JdeDataType.Numeric),
        new JdeField("N0ATPATFC", "N0ATPATFC", JdeDataType.String, 40),
        new JdeField("N0ATPATF", "N0ATPATF", JdeDataType.Numeric),
        new JdeField("N0ATPDCAF", "N0ATPDCAF", JdeDataType.String, 2),
        new JdeField("N0ATPISO", "N0ATPISO", JdeDataType.String, 2),
        new JdeField("N0ATPIIO", "N0ATPIIO", JdeDataType.String, 2),
        new JdeField("N0ATPIDWD", "N0ATPIDWD", JdeDataType.String, 2),
        new JdeField("N0ATPIRWD", "N0ATPIRWD", JdeDataType.String, 2),
        new JdeField("N0ATPINWD", "N0ATPINWD", JdeDataType.String, 2),
        new JdeField("N0ATPIUDD", "N0ATPIUDD", JdeDataType.String, 2),
        new JdeField("N0ATPIFSD", "N0ATPIFSD", JdeDataType.String, 2),
        new JdeField("N0ATPIDM", "N0ATPIDM", JdeDataType.String, 2),
        new JdeField("N0ATPIRM", "N0ATPIRM", JdeDataType.String, 2),
        new JdeField("N0ATPIDWR", "N0ATPIDWR", JdeDataType.String, 2),
        new JdeField("N0ATPIRWR", "N0ATPIRWR", JdeDataType.String, 2),
        new JdeField("N0ATPINWR", "N0ATPINWR", JdeDataType.String, 2),
        new JdeField("N0ATPIUDS", "N0ATPIUDS", JdeDataType.String, 2),
        new JdeField("N0ATPIIR", "N0ATPIIR", JdeDataType.String, 2),
        new JdeField("N0ATPISR", "N0ATPISR", JdeDataType.String, 2),
        new JdeField("N0ATPIPO", "N0ATPIPO", JdeDataType.String, 2),
        new JdeField("N0ATPIOA", "N0ATPIOA", JdeDataType.String, 2),
        new JdeField("N0ATPIIT", "N0ATPIIT", JdeDataType.String, 2),
        new JdeField("N0ATPIFSR", "N0ATPIFSR", JdeDataType.String, 2),
        new JdeField("N0URCD", "N0URCD", JdeDataType.String, 4),
        new JdeField("N0URDT", "N0URDT", JdeDataType.Numeric),
        new JdeField("N0URAT", "N0URAT", JdeDataType.Numeric),
        new JdeField("N0URAB", "N0URAB", JdeDataType.Numeric),
        new JdeField("N0URRF", "N0URRF", JdeDataType.String, 30),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0JOBN", "N0JOBN", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0TDAY", "N0TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A210_0", "Primary Key on N0ATPRN", new[] { "N0ATPRN" }, isUnique: true, isPrimaryKey: true)
    };
}
