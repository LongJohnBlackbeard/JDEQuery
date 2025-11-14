using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF18A - .
/// </summary>
public class F90CF18A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDSCRINSID.
        /// </summary>
        public const string IDSCRINSID = "IDSCRINSID";

        /// <summary>
        /// IDPARPTHID.
        /// </summary>
        public const string IDPARPTHID = "IDPARPTHID";

        /// <summary>
        /// IDQSTPTHID.
        /// </summary>
        public const string IDQSTPTHID = "IDQSTPTHID";

        /// <summary>
        /// IDROWNBR.
        /// </summary>
        public const string IDROWNBR = "IDROWNBR";

        /// <summary>
        /// IDSCRPTID.
        /// </summary>
        public const string IDSCRPTID = "IDSCRPTID";

        /// <summary>
        /// IDTGSETID.
        /// </summary>
        public const string IDTGSETID = "IDTGSETID";

        /// <summary>
        /// IDQUSTWGT.
        /// </summary>
        public const string IDQUSTWGT = "IDQUSTWGT";

        /// <summary>
        /// IDQSTGRPID.
        /// </summary>
        public const string IDQSTGRPID = "IDQSTGRPID";

        /// <summary>
        /// IDQUSTID.
        /// </summary>
        public const string IDQUSTID = "IDQUSTID";

        /// <summary>
        /// IDANSETID.
        /// </summary>
        public const string IDANSETID = "IDANSETID";

        /// <summary>
        /// IDANSWID.
        /// </summary>
        public const string IDANSWID = "IDANSWID";

        /// <summary>
        /// IDANSPTHID.
        /// </summary>
        public const string IDANSPTHID = "IDANSPTHID";

        /// <summary>
        /// IDANSSCR.
        /// </summary>
        public const string IDANSSCR = "IDANSSCR";

        /// <summary>
        /// IDANSVAL.
        /// </summary>
        public const string IDANSVAL = "IDANSVAL";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDJOBN.
        /// </summary>
        public const string IDJOBN = "IDJOBN";

        /// <summary>
        /// IDMKEY.
        /// </summary>
        public const string IDMKEY = "IDMKEY";

        /// <summary>
        /// IDUDTTM.
        /// </summary>
        public const string IDUDTTM = "IDUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF18A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDSCRINSID", "IDSCRINSID", JdeDataType.Numeric, null, true, true),
        new JdeField("IDPARPTHID", "IDPARPTHID", JdeDataType.Numeric, null, true, true),
        new JdeField("IDQSTPTHID", "IDQSTPTHID", JdeDataType.Numeric, null, true, true),
        new JdeField("IDROWNBR", "IDROWNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("IDSCRPTID", "IDSCRPTID", JdeDataType.Numeric),
        new JdeField("IDTGSETID", "IDTGSETID", JdeDataType.String, 60),
        new JdeField("IDQUSTWGT", "IDQUSTWGT", JdeDataType.Numeric),
        new JdeField("IDQSTGRPID", "IDQSTGRPID", JdeDataType.Numeric),
        new JdeField("IDQUSTID", "IDQUSTID", JdeDataType.Numeric),
        new JdeField("IDANSETID", "IDANSETID", JdeDataType.Numeric),
        new JdeField("IDANSWID", "IDANSWID", JdeDataType.Numeric),
        new JdeField("IDANSPTHID", "IDANSPTHID", JdeDataType.Numeric),
        new JdeField("IDANSSCR", "IDANSSCR", JdeDataType.Numeric),
        new JdeField("IDANSVAL", "IDANSVAL", JdeDataType.String, 510),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDJOBN", "IDJOBN", JdeDataType.String, 20),
        new JdeField("IDMKEY", "IDMKEY", JdeDataType.String, 30),
        new JdeField("IDUDTTM", "IDUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF18A_0", "Primary Key on IDSCRINSID, IDPARPTHID, IDQSTPTHID, IDROWNBR", new[] { "IDSCRINSID", "IDPARPTHID", "IDQSTPTHID", "IDROWNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
