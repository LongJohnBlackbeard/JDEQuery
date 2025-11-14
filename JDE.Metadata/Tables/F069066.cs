using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069066 - .
/// </summary>
public class F069066 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDPCCD.
        /// </summary>
        public const string JDPCCD = "JDPCCD";

        /// <summary>
        /// JDDTEY.
        /// </summary>
        public const string JDDTEY = "JDDTEY";

        /// <summary>
        /// JDPPNB.
        /// </summary>
        public const string JDPPNB = "JDPPNB";

        /// <summary>
        /// JDPPED.
        /// </summary>
        public const string JDPPED = "JDPPED";

        /// <summary>
        /// JDPPMO.
        /// </summary>
        public const string JDPPMO = "JDPPMO";

        /// <summary>
        /// JDCKDT.
        /// </summary>
        public const string JDCKDT = "JDCKDT";

        /// <summary>
        /// JDWHRW.
        /// </summary>
        public const string JDWHRW = "JDWHRW";

        /// <summary>
        /// JDBHRW.
        /// </summary>
        public const string JDBHRW = "JDBHRW";

        /// <summary>
        /// JDSHRW.
        /// </summary>
        public const string JDSHRW = "JDSHRW";

        /// <summary>
        /// JDMHRW.
        /// </summary>
        public const string JDMHRW = "JDMHRW";

        /// <summary>
        /// JDAHRW.
        /// </summary>
        public const string JDAHRW = "JDAHRW";

        /// <summary>
        /// JDOHRW.
        /// </summary>
        public const string JDOHRW = "JDOHRW";

        /// <summary>
        /// JDPPM1.
        /// </summary>
        public const string JDPPM1 = "JDPPM1";

        /// <summary>
        /// JDPPM2.
        /// </summary>
        public const string JDPPM2 = "JDPPM2";

        /// <summary>
        /// JDPPM3.
        /// </summary>
        public const string JDPPM3 = "JDPPM3";

        /// <summary>
        /// JDPPM4.
        /// </summary>
        public const string JDPPM4 = "JDPPM4";

        /// <summary>
        /// JDPPM5.
        /// </summary>
        public const string JDPPM5 = "JDPPM5";

        /// <summary>
        /// JDPPM6.
        /// </summary>
        public const string JDPPM6 = "JDPPM6";

        /// <summary>
        /// JDUSER.
        /// </summary>
        public const string JDUSER = "JDUSER";

        /// <summary>
        /// JDPID.
        /// </summary>
        public const string JDPID = "JDPID";

        /// <summary>
        /// JDUPMJ.
        /// </summary>
        public const string JDUPMJ = "JDUPMJ";

        /// <summary>
        /// JDCTRY.
        /// </summary>
        public const string JDCTRY = "JDCTRY";

        /// <summary>
        /// JDPPMB.
        /// </summary>
        public const string JDPPMB = "JDPPMB";

        /// <summary>
        /// JDADDT.
        /// </summary>
        public const string JDADDT = "JDADDT";
    }

    /// <inheritdoc />
    public override string TableName => "F069066";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDPCCD", "JDPCCD", JdeDataType.String, 10, true, true),
        new JdeField("JDDTEY", "JDDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JDPPNB", "JDPPNB", JdeDataType.String, 6, true, true),
        new JdeField("JDPPED", "JDPPED", JdeDataType.Numeric, null, true, true),
        new JdeField("JDPPMO", "JDPPMO", JdeDataType.String, 4),
        new JdeField("JDCKDT", "JDCKDT", JdeDataType.Numeric),
        new JdeField("JDWHRW", "JDWHRW", JdeDataType.Numeric),
        new JdeField("JDBHRW", "JDBHRW", JdeDataType.Numeric),
        new JdeField("JDSHRW", "JDSHRW", JdeDataType.Numeric),
        new JdeField("JDMHRW", "JDMHRW", JdeDataType.Numeric),
        new JdeField("JDAHRW", "JDAHRW", JdeDataType.Numeric),
        new JdeField("JDOHRW", "JDOHRW", JdeDataType.Numeric),
        new JdeField("JDPPM1", "JDPPM1", JdeDataType.String, 2),
        new JdeField("JDPPM2", "JDPPM2", JdeDataType.String, 2),
        new JdeField("JDPPM3", "JDPPM3", JdeDataType.String, 2),
        new JdeField("JDPPM4", "JDPPM4", JdeDataType.String, 2),
        new JdeField("JDPPM5", "JDPPM5", JdeDataType.String, 2),
        new JdeField("JDPPM6", "JDPPM6", JdeDataType.String, 2),
        new JdeField("JDUSER", "JDUSER", JdeDataType.String, 20),
        new JdeField("JDPID", "JDPID", JdeDataType.String, 20),
        new JdeField("JDUPMJ", "JDUPMJ", JdeDataType.Numeric),
        new JdeField("JDCTRY", "JDCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("JDPPMB", "JDPPMB", JdeDataType.String, 2),
        new JdeField("JDADDT", "JDADDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069066_0", "Primary Key on JDPCCD, JDCTRY, JDDTEY, JDPPNB, JDPPED", new[] { "JDPCCD", "JDCTRY", "JDDTEY", "JDPPNB", "JDPPED" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069066_2", "Index on JDPCCD, JDCTRY, JDDTEY, JDPPED", new[] { "JDPCCD", "JDCTRY", "JDDTEY", "JDPPED" }),
        new JdeIndex("F069066_3", "Index on JDPCCD, JDPPED", new[] { "JDPCCD", "JDPPED" }),
        new JdeIndex("F069066_4", "Index on JDPCCD, JDCTRY, JDDTEY, JDCKDT", new[] { "JDPCCD", "JDCTRY", "JDDTEY", "JDCKDT" }),
        new JdeIndex("F069066_5", "Index on JDCKDT, JDPCCD", new[] { "JDCKDT", "JDPCCD" }),
        new JdeIndex("F069066_6", "Index on JDPCCD, JDCTRY, JDDTEY, JDPPMO", new[] { "JDPCCD", "JDCTRY", "JDDTEY", "JDPPMO" }),
        new JdeIndex("F069066_7", "Index on SYS_NC00025$, SYS_NC00026$", new[] { "SYS_NC00025$", "SYS_NC00026$" })
    };
}
