using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08992 - .
/// </summary>
public class F08992 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QEQE1.
        /// </summary>
        public const string QEQE1 = "QEQE1";

        /// <summary>
        /// QETOIF.
        /// </summary>
        public const string QETOIF = "QETOIF";

        /// <summary>
        /// QEHMCO.
        /// </summary>
        public const string QEHMCO = "QEHMCO";

        /// <summary>
        /// QEHMCU.
        /// </summary>
        public const string QEHMCU = "QEHMCU";

        /// <summary>
        /// QETARR.
        /// </summary>
        public const string QETARR = "QETARR";

        /// <summary>
        /// QEEFTB.
        /// </summary>
        public const string QEEFTB = "QEEFTB";

        /// <summary>
        /// QEEFTE.
        /// </summary>
        public const string QEEFTE = "QEEFTE";

        /// <summary>
        /// QEUKID.
        /// </summary>
        public const string QEUKID = "QEUKID";

        /// <summary>
        /// QEUSER.
        /// </summary>
        public const string QEUSER = "QEUSER";

        /// <summary>
        /// QEPID.
        /// </summary>
        public const string QEPID = "QEPID";

        /// <summary>
        /// QEJOBN.
        /// </summary>
        public const string QEJOBN = "QEJOBN";

        /// <summary>
        /// QEUPMJ.
        /// </summary>
        public const string QEUPMJ = "QEUPMJ";

        /// <summary>
        /// QEUPMT.
        /// </summary>
        public const string QEUPMT = "QEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08992";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QEQE1", "QEQE1", JdeDataType.String, 4, true, true),
        new JdeField("QETOIF", "QETOIF", JdeDataType.String, 4, true, true),
        new JdeField("QEHMCO", "QEHMCO", JdeDataType.String, 10, true, true),
        new JdeField("QEHMCU", "QEHMCU", JdeDataType.String, 24, true, true),
        new JdeField("QETARR", "QETARR", JdeDataType.String, 20, true, true),
        new JdeField("QEEFTB", "QEEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("QEEFTE", "QEEFTE", JdeDataType.Numeric),
        new JdeField("QEUKID", "QEUKID", JdeDataType.Numeric),
        new JdeField("QEUSER", "QEUSER", JdeDataType.String, 20),
        new JdeField("QEPID", "QEPID", JdeDataType.String, 20),
        new JdeField("QEJOBN", "QEJOBN", JdeDataType.String, 20),
        new JdeField("QEUPMJ", "QEUPMJ", JdeDataType.Numeric),
        new JdeField("QEUPMT", "QEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08992_0", "Primary Key on QETOIF, QEQE1, QEHMCO, QETARR, QEHMCU, QEEFTB", new[] { "QETOIF", "QEQE1", "QEHMCO", "QETARR", "QEHMCU", "QEEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08992_3", "Unique Index on QEUKID", new[] { "QEUKID" }, isUnique: true),
        new JdeIndex("F08992_4", "Index on QETOIF, QEQE1, SYS_NC00014$, SYS_NC00015$, SYS_NC00016$", new[] { "QETOIF", "QEQE1", "SYS_NC00014$", "SYS_NC00015$", "SYS_NC00016$" })
    };
}
