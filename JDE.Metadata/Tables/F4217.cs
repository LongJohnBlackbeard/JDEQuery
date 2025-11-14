using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4217 - .
/// </summary>
public class F4217 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XISHPN.
        /// </summary>
        public const string XISHPN = "XISHPN";

        /// <summary>
        /// XIRSSN.
        /// </summary>
        public const string XIRSSN = "XIRSSN";

        /// <summary>
        /// XISQNR.
        /// </summary>
        public const string XISQNR = "XISQNR";

        /// <summary>
        /// XIREFQ.
        /// </summary>
        public const string XIREFQ = "XIREFQ";

        /// <summary>
        /// XIREFN.
        /// </summary>
        public const string XIREFN = "XIREFN";

        /// <summary>
        /// XIDOC.
        /// </summary>
        public const string XIDOC = "XIDOC";

        /// <summary>
        /// XIDCT.
        /// </summary>
        public const string XIDCT = "XIDCT";

        /// <summary>
        /// XIKCO.
        /// </summary>
        public const string XIKCO = "XIKCO";

        /// <summary>
        /// XIUSER.
        /// </summary>
        public const string XIUSER = "XIUSER";

        /// <summary>
        /// XIPID.
        /// </summary>
        public const string XIPID = "XIPID";

        /// <summary>
        /// XIJOBN.
        /// </summary>
        public const string XIJOBN = "XIJOBN";

        /// <summary>
        /// XIUPMJ.
        /// </summary>
        public const string XIUPMJ = "XIUPMJ";

        /// <summary>
        /// XITDAY.
        /// </summary>
        public const string XITDAY = "XITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4217";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XISHPN", "XISHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("XIRSSN", "XIRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("XISQNR", "XISQNR", JdeDataType.Numeric, null, true, true),
        new JdeField("XIREFQ", "XIREFQ", JdeDataType.String, 4),
        new JdeField("XIREFN", "XIREFN", JdeDataType.String, 60),
        new JdeField("XIDOC", "XIDOC", JdeDataType.Numeric),
        new JdeField("XIDCT", "XIDCT", JdeDataType.String, 4),
        new JdeField("XIKCO", "XIKCO", JdeDataType.String, 10),
        new JdeField("XIUSER", "XIUSER", JdeDataType.String, 20),
        new JdeField("XIPID", "XIPID", JdeDataType.String, 20),
        new JdeField("XIJOBN", "XIJOBN", JdeDataType.String, 20),
        new JdeField("XIUPMJ", "XIUPMJ", JdeDataType.Numeric),
        new JdeField("XITDAY", "XITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4217_0", "Primary Key on XISHPN, XIRSSN, XISQNR", new[] { "XISHPN", "XIRSSN", "XISQNR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4217_2", "Index on XISHPN, XIRSSN, XIREFQ, XIREFN", new[] { "XISHPN", "XIRSSN", "XIREFQ", "XIREFN" }),
        new JdeIndex("F4217_3", "Index on XIREFQ, XIREFN", new[] { "XIREFQ", "XIREFN" }),
        new JdeIndex("F4217_4", "Index on XISHPN, XIRSSN, SYS_NC00014$", new[] { "XISHPN", "XIRSSN", "SYS_NC00014$" }),
        new JdeIndex("F4217_5", "Index on XISHPN, XIREFN", new[] { "XISHPN", "XIREFN" })
    };
}
