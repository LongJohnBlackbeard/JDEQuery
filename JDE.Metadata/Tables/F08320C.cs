using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320C - .
/// </summary>
public class F08320C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PXPLAN.
        /// </summary>
        public const string PXPLAN = "PXPLAN";

        /// <summary>
        /// PXAOPT.
        /// </summary>
        public const string PXAOPT = "PXAOPT";

        /// <summary>
        /// PXMINDEP.
        /// </summary>
        public const string PXMINDEP = "PXMINDEP";

        /// <summary>
        /// PXPLNGRP.
        /// </summary>
        public const string PXPLNGRP = "PXPLNGRP";

        /// <summary>
        /// PXSPLDES.
        /// </summary>
        public const string PXSPLDES = "PXSPLDES";

        /// <summary>
        /// PXNPPLFL.
        /// </summary>
        public const string PXNPPLFL = "PXNPPLFL";

        /// <summary>
        /// PXUSER.
        /// </summary>
        public const string PXUSER = "PXUSER";

        /// <summary>
        /// PXPID.
        /// </summary>
        public const string PXPID = "PXPID";

        /// <summary>
        /// PXJOBN.
        /// </summary>
        public const string PXJOBN = "PXJOBN";

        /// <summary>
        /// PXUPMJ.
        /// </summary>
        public const string PXUPMJ = "PXUPMJ";

        /// <summary>
        /// PXUPMT.
        /// </summary>
        public const string PXUPMT = "PXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08320C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PXPLAN", "PXPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PXAOPT", "PXAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PXMINDEP", "PXMINDEP", JdeDataType.Numeric),
        new JdeField("PXPLNGRP", "PXPLNGRP", JdeDataType.String, 6),
        new JdeField("PXSPLDES", "PXSPLDES", JdeDataType.String, 30),
        new JdeField("PXNPPLFL", "PXNPPLFL", JdeDataType.String, 2),
        new JdeField("PXUSER", "PXUSER", JdeDataType.String, 20),
        new JdeField("PXPID", "PXPID", JdeDataType.String, 20),
        new JdeField("PXJOBN", "PXJOBN", JdeDataType.String, 20),
        new JdeField("PXUPMJ", "PXUPMJ", JdeDataType.Numeric),
        new JdeField("PXUPMT", "PXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320C_0", "Primary Key on PXPLAN, PXAOPT", new[] { "PXPLAN", "PXAOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
