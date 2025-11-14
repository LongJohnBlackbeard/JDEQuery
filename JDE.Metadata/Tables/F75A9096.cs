using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A9096 - .
/// </summary>
public class F75A9096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZCCO.
        /// </summary>
        public const string ZCCO = "ZCCO";

        /// <summary>
        /// ZCACNNO.
        /// </summary>
        public const string ZCACNNO = "ZCACNNO";

        /// <summary>
        /// ZCGRPNO.
        /// </summary>
        public const string ZCGRPNO = "ZCGRPNO";

        /// <summary>
        /// ZCWHO.
        /// </summary>
        public const string ZCWHO = "ZCWHO";

        /// <summary>
        /// ZCPH1.
        /// </summary>
        public const string ZCPH1 = "ZCPH1";

        /// <summary>
        /// ZCPHN1.
        /// </summary>
        public const string ZCPHN1 = "ZCPHN1";

        /// <summary>
        /// ZCCOEADD.
        /// </summary>
        public const string ZCCOEADD = "ZCCOEADD";

        /// <summary>
        /// ZCUSER.
        /// </summary>
        public const string ZCUSER = "ZCUSER";

        /// <summary>
        /// ZCUPMJ.
        /// </summary>
        public const string ZCUPMJ = "ZCUPMJ";

        /// <summary>
        /// ZCUPMT.
        /// </summary>
        public const string ZCUPMT = "ZCUPMT";

        /// <summary>
        /// ZCPID.
        /// </summary>
        public const string ZCPID = "ZCPID";

        /// <summary>
        /// ZCJOBN.
        /// </summary>
        public const string ZCJOBN = "ZCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A9096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZCCO", "ZCCO", JdeDataType.String, 10, true, true),
        new JdeField("ZCACNNO", "ZCACNNO", JdeDataType.String, 30),
        new JdeField("ZCGRPNO", "ZCGRPNO", JdeDataType.String, 22),
        new JdeField("ZCWHO", "ZCWHO", JdeDataType.String, 240),
        new JdeField("ZCPH1", "ZCPH1", JdeDataType.String, 40),
        new JdeField("ZCPHN1", "ZCPHN1", JdeDataType.String, 40),
        new JdeField("ZCCOEADD", "ZCCOEADD", JdeDataType.String, 160),
        new JdeField("ZCUSER", "ZCUSER", JdeDataType.String, 20),
        new JdeField("ZCUPMJ", "ZCUPMJ", JdeDataType.Numeric),
        new JdeField("ZCUPMT", "ZCUPMT", JdeDataType.Numeric),
        new JdeField("ZCPID", "ZCPID", JdeDataType.String, 20),
        new JdeField("ZCJOBN", "ZCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A9096_0", "Primary Key on ZCCO", new[] { "ZCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
