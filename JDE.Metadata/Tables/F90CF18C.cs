using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF18C - .
/// </summary>
public class F90CF18C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITSCRINSID.
        /// </summary>
        public const string ITSCRINSID = "ITSCRINSID";

        /// <summary>
        /// ITEFFSEQ.
        /// </summary>
        public const string ITEFFSEQ = "ITEFFSEQ";

        /// <summary>
        /// ITTKNNAM.
        /// </summary>
        public const string ITTKNNAM = "ITTKNNAM";

        /// <summary>
        /// ITANSVAL.
        /// </summary>
        public const string ITANSVAL = "ITANSVAL";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";

        /// <summary>
        /// ITMKEY.
        /// </summary>
        public const string ITMKEY = "ITMKEY";

        /// <summary>
        /// ITUDTTM.
        /// </summary>
        public const string ITUDTTM = "ITUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF18C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITSCRINSID", "ITSCRINSID", JdeDataType.Numeric, null, true, true),
        new JdeField("ITEFFSEQ", "ITEFFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ITTKNNAM", "ITTKNNAM", JdeDataType.String, 60),
        new JdeField("ITANSVAL", "ITANSVAL", JdeDataType.String, 510),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20),
        new JdeField("ITMKEY", "ITMKEY", JdeDataType.String, 30),
        new JdeField("ITUDTTM", "ITUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF18C_0", "Primary Key on ITSCRINSID, ITEFFSEQ", new[] { "ITSCRINSID", "ITEFFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
