using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15221 - .
/// </summary>
public class F15221 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UFUNITTEMP.
        /// </summary>
        public const string UFUNITTEMP = "UFUNITTEMP";

        /// <summary>
        /// UFUNITTAB.
        /// </summary>
        public const string UFUNITTAB = "UFUNITTAB";

        /// <summary>
        /// UFSEQ1.
        /// </summary>
        public const string UFSEQ1 = "UFSEQ1";

        /// <summary>
        /// UFSEQ.
        /// </summary>
        public const string UFSEQ = "UFSEQ";

        /// <summary>
        /// UFATTRDTAI.
        /// </summary>
        public const string UFATTRDTAI = "UFATTRDTAI";

        /// <summary>
        /// UFATTRIBTY.
        /// </summary>
        public const string UFATTRIBTY = "UFATTRIBTY";

        /// <summary>
        /// UFUSER.
        /// </summary>
        public const string UFUSER = "UFUSER";

        /// <summary>
        /// UFUPMJ.
        /// </summary>
        public const string UFUPMJ = "UFUPMJ";

        /// <summary>
        /// UFUPMT.
        /// </summary>
        public const string UFUPMT = "UFUPMT";

        /// <summary>
        /// UFMKEY.
        /// </summary>
        public const string UFMKEY = "UFMKEY";

        /// <summary>
        /// UFPID.
        /// </summary>
        public const string UFPID = "UFPID";

        /// <summary>
        /// UFUNITDIS.
        /// </summary>
        public const string UFUNITDIS = "UFUNITDIS";
    }

    /// <inheritdoc />
    public override string TableName => "F15221";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UFUNITTEMP", "UFUNITTEMP", JdeDataType.String, 80, true, true),
        new JdeField("UFUNITTAB", "UFUNITTAB", JdeDataType.Numeric, null, true, true),
        new JdeField("UFSEQ1", "UFSEQ1", JdeDataType.Numeric, null, true, true),
        new JdeField("UFSEQ", "UFSEQ", JdeDataType.Numeric),
        new JdeField("UFATTRDTAI", "UFATTRDTAI", JdeDataType.String, 20),
        new JdeField("UFATTRIBTY", "UFATTRIBTY", JdeDataType.String, 2),
        new JdeField("UFUSER", "UFUSER", JdeDataType.String, 20),
        new JdeField("UFUPMJ", "UFUPMJ", JdeDataType.Numeric),
        new JdeField("UFUPMT", "UFUPMT", JdeDataType.Numeric),
        new JdeField("UFMKEY", "UFMKEY", JdeDataType.String, 30),
        new JdeField("UFPID", "UFPID", JdeDataType.String, 20),
        new JdeField("UFUNITDIS", "UFUNITDIS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15221_0", "Primary Key on UFUNITTEMP, UFUNITTAB, UFSEQ1", new[] { "UFUNITTEMP", "UFUNITTAB", "UFSEQ1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15221_2", "Index on UFUNITTEMP, UFUNITTAB, UFSEQ", new[] { "UFUNITTEMP", "UFUNITTAB", "UFSEQ" })
    };
}
