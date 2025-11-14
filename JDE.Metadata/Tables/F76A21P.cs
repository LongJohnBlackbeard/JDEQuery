using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A21P - .
/// </summary>
public class F76A21P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHKCO.
        /// </summary>
        public const string IHKCO = "IHKCO";

        /// <summary>
        /// IHDCT.
        /// </summary>
        public const string IHDCT = "IHDCT";

        /// <summary>
        /// IHDOC.
        /// </summary>
        public const string IHDOC = "IHDOC";

        /// <summary>
        /// IHADGI.
        /// </summary>
        public const string IHADGI = "IHADGI";

        /// <summary>
        /// IHACEM.
        /// </summary>
        public const string IHACEM = "IHACEM";

        /// <summary>
        /// IHAGRP.
        /// </summary>
        public const string IHAGRP = "IHAGRP";

        /// <summary>
        /// IHAINW.
        /// </summary>
        public const string IHAINW = "IHAINW";

        /// <summary>
        /// IHNSP.
        /// </summary>
        public const string IHNSP = "IHNSP";

        /// <summary>
        /// IHDIVJ.
        /// </summary>
        public const string IHDIVJ = "IHDIVJ";

        /// <summary>
        /// IHRCPD.
        /// </summary>
        public const string IHRCPD = "IHRCPD";

        /// <summary>
        /// IHCRRM.
        /// </summary>
        public const string IHCRRM = "IHCRRM";

        /// <summary>
        /// IHCRCD.
        /// </summary>
        public const string IHCRCD = "IHCRCD";

        /// <summary>
        /// IHCRR.
        /// </summary>
        public const string IHCRR = "IHCRR";

        /// <summary>
        /// IHAG.
        /// </summary>
        public const string IHAG = "IHAG";

        /// <summary>
        /// IHACR.
        /// </summary>
        public const string IHACR = "IHACR";

        /// <summary>
        /// IHAEST.
        /// </summary>
        public const string IHAEST = "IHAEST";

        /// <summary>
        /// IHPTC.
        /// </summary>
        public const string IHPTC = "IHPTC";

        /// <summary>
        /// IHTXA1.
        /// </summary>
        public const string IHTXA1 = "IHTXA1";

        /// <summary>
        /// IHPNMG.
        /// </summary>
        public const string IHPNMG = "IHPNMG";

        /// <summary>
        /// IHINMG.
        /// </summary>
        public const string IHINMG = "IHINMG";

        /// <summary>
        /// IHURRF.
        /// </summary>
        public const string IHURRF = "IHURRF";

        /// <summary>
        /// IHURCD.
        /// </summary>
        public const string IHURCD = "IHURCD";

        /// <summary>
        /// IHURDT.
        /// </summary>
        public const string IHURDT = "IHURDT";

        /// <summary>
        /// IHURAT.
        /// </summary>
        public const string IHURAT = "IHURAT";

        /// <summary>
        /// IHURAB.
        /// </summary>
        public const string IHURAB = "IHURAB";

        /// <summary>
        /// IHCTID.
        /// </summary>
        public const string IHCTID = "IHCTID";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHUPMJ.
        /// </summary>
        public const string IHUPMJ = "IHUPMJ";

        /// <summary>
        /// IHUPMT.
        /// </summary>
        public const string IHUPMT = "IHUPMT";

        /// <summary>
        /// IHADGI1.
        /// </summary>
        public const string IHADGI1 = "IHADGI1";

        /// <summary>
        /// IHACEM1.
        /// </summary>
        public const string IHACEM1 = "IHACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A21P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHKCO", "IHKCO", JdeDataType.String, 10, true, true),
        new JdeField("IHDCT", "IHDCT", JdeDataType.String, 4, true, true),
        new JdeField("IHDOC", "IHDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IHADGI", "IHADGI", JdeDataType.String, 4),
        new JdeField("IHACEM", "IHACEM", JdeDataType.String, 8),
        new JdeField("IHAGRP", "IHAGRP", JdeDataType.String, 2),
        new JdeField("IHAINW", "IHAINW", JdeDataType.String, 16),
        new JdeField("IHNSP", "IHNSP", JdeDataType.Numeric),
        new JdeField("IHDIVJ", "IHDIVJ", JdeDataType.Numeric),
        new JdeField("IHRCPD", "IHRCPD", JdeDataType.Numeric),
        new JdeField("IHCRRM", "IHCRRM", JdeDataType.String, 2),
        new JdeField("IHCRCD", "IHCRCD", JdeDataType.String, 6),
        new JdeField("IHCRR", "IHCRR", JdeDataType.Numeric),
        new JdeField("IHAG", "IHAG", JdeDataType.Numeric),
        new JdeField("IHACR", "IHACR", JdeDataType.Numeric),
        new JdeField("IHAEST", "IHAEST", JdeDataType.String, 2),
        new JdeField("IHPTC", "IHPTC", JdeDataType.String, 6),
        new JdeField("IHTXA1", "IHTXA1", JdeDataType.String, 20),
        new JdeField("IHPNMG", "IHPNMG", JdeDataType.String, 20),
        new JdeField("IHINMG", "IHINMG", JdeDataType.String, 20),
        new JdeField("IHURRF", "IHURRF", JdeDataType.String, 30),
        new JdeField("IHURCD", "IHURCD", JdeDataType.String, 4),
        new JdeField("IHURDT", "IHURDT", JdeDataType.Numeric),
        new JdeField("IHURAT", "IHURAT", JdeDataType.Numeric),
        new JdeField("IHURAB", "IHURAB", JdeDataType.Numeric),
        new JdeField("IHCTID", "IHCTID", JdeDataType.String, 30),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHUPMJ", "IHUPMJ", JdeDataType.Numeric),
        new JdeField("IHUPMT", "IHUPMT", JdeDataType.Numeric),
        new JdeField("IHADGI1", "IHADGI1", JdeDataType.String, 20),
        new JdeField("IHACEM1", "IHACEM1", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A21P_0", "Primary Key on IHKCO, IHDCT, IHDOC", new[] { "IHKCO", "IHDCT", "IHDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
