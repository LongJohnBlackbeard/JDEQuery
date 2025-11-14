using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA18C - .
/// </summary>
public class F90CA18C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STCOMDATE.
        /// </summary>
        public const string STCOMDATE = "STCOMDATE";

        /// <summary>
        /// STEDATE.
        /// </summary>
        public const string STEDATE = "STEDATE";

        /// <summary>
        /// STSTSUDT.
        /// </summary>
        public const string STSTSUDT = "STSTSUDT";

        /// <summary>
        /// STACTIND.
        /// </summary>
        public const string STACTIND = "STACTIND";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STVID.
        /// </summary>
        public const string STVID = "STVID";

        /// <summary>
        /// STMKEY.
        /// </summary>
        public const string STMKEY = "STMKEY";

        /// <summary>
        /// STUDTTM.
        /// </summary>
        public const string STUDTTM = "STUDTTM";

        /// <summary>
        /// STENTDBY.
        /// </summary>
        public const string STENTDBY = "STENTDBY";

        /// <summary>
        /// STSI03.
        /// </summary>
        public const string STSI03 = "STSI03";

        /// <summary>
        /// STALGNTERR.
        /// </summary>
        public const string STALGNTERR = "STALGNTERR";

        /// <summary>
        /// STALGNCIG.
        /// </summary>
        public const string STALGNCIG = "STALGNCIG";

        /// <summary>
        /// STUKID.
        /// </summary>
        public const string STUKID = "STUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA18C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STCOMDATE", "STCOMDATE", JdeDataType.Date),
        new JdeField("STEDATE", "STEDATE", JdeDataType.Date),
        new JdeField("STSTSUDT", "STSTSUDT", JdeDataType.Date),
        new JdeField("STACTIND", "STACTIND", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STVID", "STVID", JdeDataType.String, 20),
        new JdeField("STMKEY", "STMKEY", JdeDataType.String, 30),
        new JdeField("STUDTTM", "STUDTTM", JdeDataType.Date),
        new JdeField("STENTDBY", "STENTDBY", JdeDataType.Numeric),
        new JdeField("STSI03", "STSI03", JdeDataType.String, 2),
        new JdeField("STALGNTERR", "STALGNTERR", JdeDataType.String, 2),
        new JdeField("STALGNCIG", "STALGNCIG", JdeDataType.String, 2),
        new JdeField("STUKID", "STUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA18C_0", "Primary Key on STAN8, STUKID", new[] { "STAN8", "STUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA18C_2", "Index on STCOMDATE", new[] { "STCOMDATE" })
    };
}
