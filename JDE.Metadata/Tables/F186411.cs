using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186411 - .
/// </summary>
public class F186411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPLRSPEXLC.
        /// </summary>
        public const string OPLRSPEXLC = "OPLRSPEXLC";

        /// <summary>
        /// OPLRSORSID.
        /// </summary>
        public const string OPLRSORSID = "OPLRSORSID";

        /// <summary>
        /// OPLRSORID.
        /// </summary>
        public const string OPLRSORID = "OPLRSORID";

        /// <summary>
        /// OPPPYF.
        /// </summary>
        public const string OPPPYF = "OPPPYF";

        /// <summary>
        /// OPPPYT.
        /// </summary>
        public const string OPPPYT = "OPPPYT";

        /// <summary>
        /// OPTCACH01.
        /// </summary>
        public const string OPTCACH01 = "OPTCACH01";

        /// <summary>
        /// OPTCACH02.
        /// </summary>
        public const string OPTCACH02 = "OPTCACH02";

        /// <summary>
        /// OPTCAMN01.
        /// </summary>
        public const string OPTCAMN01 = "OPTCAMN01";

        /// <summary>
        /// OPTCAMN02.
        /// </summary>
        public const string OPTCAMN02 = "OPTCAMN02";

        /// <summary>
        /// OPTCAJD01.
        /// </summary>
        public const string OPTCAJD01 = "OPTCAJD01";

        /// <summary>
        /// OPTCAJD02.
        /// </summary>
        public const string OPTCAJD02 = "OPTCAJD02";

        /// <summary>
        /// OPTCAST01.
        /// </summary>
        public const string OPTCAST01 = "OPTCAST01";

        /// <summary>
        /// OPTCAST02.
        /// </summary>
        public const string OPTCAST02 = "OPTCAST02";

        /// <summary>
        /// OPTCAST03.
        /// </summary>
        public const string OPTCAST03 = "OPTCAST03";

        /// <summary>
        /// OPTCAST04.
        /// </summary>
        public const string OPTCAST04 = "OPTCAST04";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPJOBN.
        /// </summary>
        public const string OPJOBN = "OPJOBN";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPUPMT.
        /// </summary>
        public const string OPUPMT = "OPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F186411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPLRSPEXLC", "OPLRSPEXLC", JdeDataType.String, 2, true, true),
        new JdeField("OPLRSORSID", "OPLRSORSID", JdeDataType.Numeric, null, true, true),
        new JdeField("OPLRSORID", "OPLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OPPPYF", "OPPPYF", JdeDataType.Numeric, null, true, true),
        new JdeField("OPPPYT", "OPPPYT", JdeDataType.Numeric),
        new JdeField("OPTCACH01", "OPTCACH01", JdeDataType.String, 2),
        new JdeField("OPTCACH02", "OPTCACH02", JdeDataType.String, 2),
        new JdeField("OPTCAMN01", "OPTCAMN01", JdeDataType.Numeric),
        new JdeField("OPTCAMN02", "OPTCAMN02", JdeDataType.Numeric),
        new JdeField("OPTCAJD01", "OPTCAJD01", JdeDataType.Numeric),
        new JdeField("OPTCAJD02", "OPTCAJD02", JdeDataType.Numeric),
        new JdeField("OPTCAST01", "OPTCAST01", JdeDataType.String, 20),
        new JdeField("OPTCAST02", "OPTCAST02", JdeDataType.String, 20),
        new JdeField("OPTCAST03", "OPTCAST03", JdeDataType.String, 40),
        new JdeField("OPTCAST04", "OPTCAST04", JdeDataType.String, 40),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPJOBN", "OPJOBN", JdeDataType.String, 20),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPUPMT", "OPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186411_0", "Primary Key on OPLRSPEXLC, OPLRSORSID, OPLRSORID, OPPPYF", new[] { "OPLRSPEXLC", "OPLRSORSID", "OPLRSORID", "OPPPYF" }, isUnique: true, isPrimaryKey: true)
    };
}
