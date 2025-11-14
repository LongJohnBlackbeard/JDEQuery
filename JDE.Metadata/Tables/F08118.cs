using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08118 - .
/// </summary>
public class F08118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEAN8.
        /// </summary>
        public const string PEAN8 = "PEAN8";

        /// <summary>
        /// PEDST.
        /// </summary>
        public const string PEDST = "PEDST";

        /// <summary>
        /// PEEFTO.
        /// </summary>
        public const string PEEFTO = "PEEFTO";

        /// <summary>
        /// PETRS.
        /// </summary>
        public const string PETRS = "PETRS";

        /// <summary>
        /// PEDT.
        /// </summary>
        public const string PEDT = "PEDT";

        /// <summary>
        /// PEEFTQ.
        /// </summary>
        public const string PEEFTQ = "PEEFTQ";

        /// <summary>
        /// PEOWTRS.
        /// </summary>
        public const string PEOWTRS = "PEOWTRS";

        /// <summary>
        /// PESPASUSG1.
        /// </summary>
        public const string PESPASUSG1 = "PESPASUSG1";

        /// <summary>
        /// PESPASUSG2.
        /// </summary>
        public const string PESPASUSG2 = "PESPASUSG2";

        /// <summary>
        /// PESPASUSG3.
        /// </summary>
        public const string PESPASUSG3 = "PESPASUSG3";

        /// <summary>
        /// PESPASUSG4.
        /// </summary>
        public const string PESPASUSG4 = "PESPASUSG4";

        /// <summary>
        /// PESPANUSG1.
        /// </summary>
        public const string PESPANUSG1 = "PESPANUSG1";

        /// <summary>
        /// PESPANUSG2.
        /// </summary>
        public const string PESPANUSG2 = "PESPANUSG2";

        /// <summary>
        /// PESPANUSG3.
        /// </summary>
        public const string PESPANUSG3 = "PESPANUSG3";

        /// <summary>
        /// PESPANUSG4.
        /// </summary>
        public const string PESPANUSG4 = "PESPANUSG4";

        /// <summary>
        /// PESPADUSG1.
        /// </summary>
        public const string PESPADUSG1 = "PESPADUSG1";

        /// <summary>
        /// PESPADUSG2.
        /// </summary>
        public const string PESPADUSG2 = "PESPADUSG2";

        /// <summary>
        /// PESPADUSG3.
        /// </summary>
        public const string PESPADUSG3 = "PESPADUSG3";

        /// <summary>
        /// PESPADUSG4.
        /// </summary>
        public const string PESPADUSG4 = "PESPADUSG4";

        /// <summary>
        /// PESPACUSG1.
        /// </summary>
        public const string PESPACUSG1 = "PESPACUSG1";

        /// <summary>
        /// PESPACUSG2.
        /// </summary>
        public const string PESPACUSG2 = "PESPACUSG2";

        /// <summary>
        /// PESPACUSG3.
        /// </summary>
        public const string PESPACUSG3 = "PESPACUSG3";

        /// <summary>
        /// PESPACUSG4.
        /// </summary>
        public const string PESPACUSG4 = "PESPACUSG4";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PEUPMT.
        /// </summary>
        public const string PEUPMT = "PEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEAN8", "PEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PEDST", "PEDST", JdeDataType.Numeric, null, true, true),
        new JdeField("PEEFTO", "PEEFTO", JdeDataType.Numeric),
        new JdeField("PETRS", "PETRS", JdeDataType.String, 6),
        new JdeField("PEDT", "PEDT", JdeDataType.Numeric),
        new JdeField("PEEFTQ", "PEEFTQ", JdeDataType.Numeric),
        new JdeField("PEOWTRS", "PEOWTRS", JdeDataType.String, 6),
        new JdeField("PESPASUSG1", "PESPASUSG1", JdeDataType.String, 60),
        new JdeField("PESPASUSG2", "PESPASUSG2", JdeDataType.String, 60),
        new JdeField("PESPASUSG3", "PESPASUSG3", JdeDataType.String, 60),
        new JdeField("PESPASUSG4", "PESPASUSG4", JdeDataType.String, 60),
        new JdeField("PESPANUSG1", "PESPANUSG1", JdeDataType.Numeric),
        new JdeField("PESPANUSG2", "PESPANUSG2", JdeDataType.Numeric),
        new JdeField("PESPANUSG3", "PESPANUSG3", JdeDataType.Numeric),
        new JdeField("PESPANUSG4", "PESPANUSG4", JdeDataType.Numeric),
        new JdeField("PESPADUSG1", "PESPADUSG1", JdeDataType.Numeric),
        new JdeField("PESPADUSG2", "PESPADUSG2", JdeDataType.Numeric),
        new JdeField("PESPADUSG3", "PESPADUSG3", JdeDataType.Numeric),
        new JdeField("PESPADUSG4", "PESPADUSG4", JdeDataType.Numeric),
        new JdeField("PESPACUSG1", "PESPACUSG1", JdeDataType.String, 2),
        new JdeField("PESPACUSG2", "PESPACUSG2", JdeDataType.String, 2),
        new JdeField("PESPACUSG3", "PESPACUSG3", JdeDataType.String, 2),
        new JdeField("PESPACUSG4", "PESPACUSG4", JdeDataType.String, 2),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PEUPMT", "PEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08118_0", "Primary Key on PEAN8, PEDST", new[] { "PEAN8", "PEDST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08118_2", "Index on PEAN8, SYS_NC00029$", new[] { "PEAN8", "SYS_NC00029$" })
    };
}
