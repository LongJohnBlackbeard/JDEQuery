using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08496 - .
/// </summary>
public class F08496 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFNURC.
        /// </summary>
        public const string RFNURC = "RFNURC";

        /// <summary>
        /// RFPSTNO.
        /// </summary>
        public const string RFPSTNO = "RFPSTNO";

        /// <summary>
        /// RFALPH.
        /// </summary>
        public const string RFALPH = "RFALPH";

        /// <summary>
        /// RFAR1.
        /// </summary>
        public const string RFAR1 = "RFAR1";

        /// <summary>
        /// RFPH1.
        /// </summary>
        public const string RFPH1 = "RFPH1";

        /// <summary>
        /// RFCONAME.
        /// </summary>
        public const string RFCONAME = "RFCONAME";

        /// <summary>
        /// RFEMAL.
        /// </summary>
        public const string RFEMAL = "RFEMAL";

        /// <summary>
        /// RFSATTL.
        /// </summary>
        public const string RFSATTL = "RFSATTL";

        /// <summary>
        /// RFRELDES.
        /// </summary>
        public const string RFRELDES = "RFRELDES";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFMKEY.
        /// </summary>
        public const string RFMKEY = "RFMKEY";

        /// <summary>
        /// RFUPMJ.
        /// </summary>
        public const string RFUPMJ = "RFUPMJ";

        /// <summary>
        /// RFUPMT.
        /// </summary>
        public const string RFUPMT = "RFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08496";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFNURC", "RFNURC", JdeDataType.Numeric, null, true, true),
        new JdeField("RFPSTNO", "RFPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("RFALPH", "RFALPH", JdeDataType.String, 80, true, true),
        new JdeField("RFAR1", "RFAR1", JdeDataType.String, 12),
        new JdeField("RFPH1", "RFPH1", JdeDataType.String, 40),
        new JdeField("RFCONAME", "RFCONAME", JdeDataType.String, 80),
        new JdeField("RFEMAL", "RFEMAL", JdeDataType.String, 512),
        new JdeField("RFSATTL", "RFSATTL", JdeDataType.String, 80),
        new JdeField("RFRELDES", "RFRELDES", JdeDataType.String, 60),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFMKEY", "RFMKEY", JdeDataType.String, 30),
        new JdeField("RFUPMJ", "RFUPMJ", JdeDataType.Numeric),
        new JdeField("RFUPMT", "RFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08496_0", "Primary Key on RFNURC, RFPSTNO, RFALPH", new[] { "RFNURC", "RFPSTNO", "RFALPH" }, isUnique: true, isPrimaryKey: true)
    };
}
