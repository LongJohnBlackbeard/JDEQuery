using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0429 - .
/// </summary>
public class F74U0429 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRDTAI.
        /// </summary>
        public const string CRDTAI = "CRDTAI";

        /// <summary>
        /// CRLNID.
        /// </summary>
        public const string CRLNID = "CRLNID";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CROBJ.
        /// </summary>
        public const string CROBJ = "CROBJ";

        /// <summary>
        /// CRSUB.
        /// </summary>
        public const string CRSUB = "CRSUB";

        /// <summary>
        /// CRDSC1.
        /// </summary>
        public const string CRDSC1 = "CRDSC1";

        /// <summary>
        /// CR74UACTF.
        /// </summary>
        public const string CR74UACTF = "CR74UACTF";

        /// <summary>
        /// CR74UAHSF.
        /// </summary>
        public const string CR74UAHSF = "CR74UAHSF";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0429";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRDTAI", "CRDTAI", JdeDataType.String, 20, true, true),
        new JdeField("CRLNID", "CRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24),
        new JdeField("CROBJ", "CROBJ", JdeDataType.String, 12),
        new JdeField("CRSUB", "CRSUB", JdeDataType.String, 16),
        new JdeField("CRDSC1", "CRDSC1", JdeDataType.String, 60),
        new JdeField("CR74UACTF", "CR74UACTF", JdeDataType.String, 2),
        new JdeField("CR74UAHSF", "CR74UAHSF", JdeDataType.String, 2),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0429_0", "Primary Key on CRDTAI, CRLNID", new[] { "CRDTAI", "CRLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
